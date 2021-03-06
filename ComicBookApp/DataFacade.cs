﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;
using ComicBookApp.Models;
using System.IO;
using System.Collections.ObjectModel;

namespace ComicBookApp
{
    class DataFacade
    {
        private const string PrivateKey = "c384b658877d2255e03b15960b5a487578d55a2c";
        private const string PublicKey = "e98db9f33a8ac2dbd7950fc03e04f163";
        private const int MaxCharacters = 1500;
        private const string ImageNotAvailablePath = "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available";

        public static async Task PopulateMarvelCharactersAsync(ObservableCollection<Character> marvelCharacters)
        {
            try {
                var characterDataWrapper = await GetCharacterDataWrapper();

                var characters = characterDataWrapper.data.results;

                foreach (var character in characters)
                {
                    //filter characters with no image
                    if (character.thumbnail != null
                        && character.thumbnail.path != ""
                        && character.thumbnail.path != ImageNotAvailablePath)
                    {
                        character.thumbnail.large = String.Format("{0}/portrait_xlarge.{1}",
                            character.thumbnail.path,
                            character.thumbnail.extension);

                        character.thumbnail.extraLarge = String.Format("{0}/portrait_uncanny.{1}",
                            character.thumbnail.path,
                            character.thumbnail.extension);

                        marvelCharacters.Add(character);
                    }

                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private async static Task<CharacterDataWrapper> GetCharacterDataWrapper()
        {
            //creates a new instance of random
            Random random = new Random();
            //creates the offset used in the url the random is vretaed using the max charaters which is 1500
            var offset = random.Next(MaxCharacters);

            var timeStamp = DateTime.Now.Ticks.ToString();
            var hash = MakeAHash(timeStamp);

            string url = String.Format("http://gateway.marvel.com:80/v1/public/characters?limit=15&offset={0}&apikey={1}&ts={2}&hash={3}", offset, PublicKey, timeStamp, hash);

            //call to API
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMess = await response.Content.ReadAsStringAsync();

            // Deserializes JSON data to c# objects
            var serializer = new DataContractJsonSerializer(typeof(CharacterDataWrapper));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMess));

            
            var result = (CharacterDataWrapper)serializer.ReadObject(ms);

            return result;
        }
        //============================================================================================================================
        //this method adds the Marvel comics to an Observable Collection
        public static async Task PopulateMarvelComicsAsync(ObservableCollection<ComicComic> marvelComics)
        {
            try {
                var comicDataWrapper = await GetComicDataWrapper();

                var comics = comicDataWrapper.data.results;

                foreach (var comic in comics)
                {
                    //filter characters with no image
                    if (comic.thumbnail != null
                        && comic.thumbnail.path != ""
                        && comic.thumbnail.path != ImageNotAvailablePath)
                    {
                        comic.thumbnail.large = String.Format("{0}/portrait_xlarge.{1}",
                            comic.thumbnail.path,
                            comic.thumbnail.extension);

                        comic.thumbnail.extraLarge = String.Format("{0}/portrait_uncanny.{1}",
                            comic.thumbnail.path,
                            comic.thumbnail.extension);

                        marvelComics.Add(comic);
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public static async Task<ComicDataWrapper> GetComicDataWrapper()
        {
            // Assemble the URL
            Random random = new Random();
            var offset = random.Next(MaxCharacters);

            // Get the MD5 Hash
            var timeStamp = DateTime.Now.Ticks.ToString();
            var hash = MakeAHash(timeStamp);

            string url = String.Format("http://gateway.marvel.com:80/v1/public/comics?limit=20&offset={0}&apikey={1}&ts={2}&hash={3}", offset, PublicKey, timeStamp, hash);

            // Call out Api
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            // Deserializes JSON data to c# objects
            var serializer = new DataContractJsonSerializer(typeof(ComicDataWrapper));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (ComicDataWrapper)serializer.ReadObject(ms);
            return result;
        }
        //============================================================================================================================
        //
        public static async Task PopulateMarvelCreatorAsync(ObservableCollection<CreatorCreator> marvelCreators)
        {
            try
            {
                var creatorDataWrapper = await GetCreatorDataWrapper();

                var creators = creatorDataWrapper.data.results;

                foreach (var creator in creators)
                {
                    //filter characters with no image
                    if (creator.thumbnail != null
                        && creator.thumbnail.path != ""
                        && creator.thumbnail.path != ImageNotAvailablePath)
                    {
                        creator.thumbnail.large = String.Format("{0}/portrait_xlarge.{1}",
                            creator.thumbnail.path,
                            creator.thumbnail.extension);

                        creator.thumbnail.extraLarge = String.Format("{0}/portrait_uncanny.{1}",
                            creator.thumbnail.path,
                            creator.thumbnail.extension);

                        marvelCreators.Add(creator);
                    }
                }
            }
            catch (Exception)
            {
                return;
            }

        }
        private async static Task<CreatorDataWrapper> GetCreatorDataWrapper()
        {
            Random random = new Random();
            var offset = random.Next(MaxCharacters);

            var timeStamp = DateTime.Now.Ticks.ToString();
            var hash = MakeAHash(timeStamp);

            string url = String.Format("http://gateway.marvel.com:80/v1/public/creators?limit=20&offset={0}&apikey={1}&ts={2}&hash={3}", offset, PublicKey, timeStamp, hash);

            //call to API
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMess = await response.Content.ReadAsStringAsync();

            var serializer = new DataContractJsonSerializer(typeof(CreatorDataWrapper));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMess));

            var result = (CreatorDataWrapper)serializer.ReadObject(ms);

            return result;
        }
        //=================================================================================================================================
        //this method creates a hash using the timestamp + PrivateKey + PublicKey it passes the the variable toBeHashed to the 
        //ComputeMD5 method
        private static string MakeAHash(string timeStamp)
        {
            var toBeHashed = timeStamp + PrivateKey + PublicKey;
            var hashedMessage = ComputeMD5(toBeHashed);
            return hashedMessage;
        }

        // From:
        // http://stackoverflow.com/questions/8299142/how-to-generate-md5-hash-code-for-my-winrt-app-using-c
        private static string ComputeMD5(string str)
        {
            var alg = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Md5);
            IBuffer buff = CryptographicBuffer.ConvertStringToBinary(str, BinaryStringEncoding.Utf8);
            var hashed = alg.HashData(buff);
            var res = CryptographicBuffer.EncodeToHexString(hashed);
            return res;
        }
    }
}




