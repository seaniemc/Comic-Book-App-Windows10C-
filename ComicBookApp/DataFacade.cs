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
            var characterDataWrapper = await GetCharacterDataWrapper();

            var characters = characterDataWrapper.data.results;

            foreach (var character in characters)
            {
                //filter characters with no image
                if(character.thumbnail != null
                    && character.thumbnail.path != ""
                    && character.thumbnail.path != ImageNotAvailablePath)
                {
                    character.thumbnail.small = String.Format("{0}/standard_small.{1}",
                        character.thumbnail.path,
                        character.thumbnail.extension);

                    character.thumbnail.large = String.Format("{0}/portrait_xlarge.{1}",
                        character.thumbnail.path,
                        character.thumbnail.extension);

                    character.thumbnail.extraLarge= String.Format("{0}/portrait_uncanny.{1}",
                        character.thumbnail.path,
                        character.thumbnail.extension);

                    marvelCharacters.Add(character);
                }
                
            }
        }

        public static async Task PopulateMarvelComicsAsync(ObservableCollection<ComicComic> marvelComics)
        {
            var comicDataWrapper = await GetComicDataWrapper();

            var comics = comicDataWrapper.data.results;

            foreach (var comic in comics)
            {
                //filter characters with no image
                if (comic.thumbnail != null
                    && comic.thumbnail.path != ""
                    && comic.thumbnail.path != ImageNotAvailablePath)
                {
                    comic.thumbnail.small = String.Format("{0}/standard_small.{1}",
                        comic.thumbnail.path,
                        comic.thumbnail.extension);

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


        private async static Task<CharacterDataWrapper> GetCharacterDataWrapper()
        {
            Random random = new Random();
            var offset = random.Next(MaxCharacters);

            var timeStamp = DateTime.Now.Ticks.ToString();
            var hash = MakeAHash(timeStamp);

            string url = String.Format("http://gateway.marvel.com:80/v1/public/characters?limit=10&offset={0}&apikey={1}&ts={2}&hash={3}", offset, PublicKey, timeStamp, hash);

            //call to API
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMess = await response.Content.ReadAsStringAsync();

            var serializer = new DataContractJsonSerializer(typeof(CharacterDataWrapper));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMess));

            var result = (CharacterDataWrapper)serializer.ReadObject(ms);

            return result;
        }

        private async static Task<CharacterDataWrapper> GetCharacterIdDataWrapper()
        {
            Random random = new Random();
            var offset = random.Next(MaxCharacters);

            //var characterId = MainPage.GetChar
            var timeStamp = DateTime.Now.Ticks.ToString();
            var hash = MakeAHash(timeStamp);

            string url = String.Format("http://gateway.marvel.com:80/v1/public/characters?limit=10&offset={0}&apikey={1}&ts={2}&hash={3}", offset, PublicKey, timeStamp, hash);

            //call to API
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMess = await response.Content.ReadAsStringAsync();

            var serializer = new DataContractJsonSerializer(typeof(CharacterDataWrapper));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMess));

            var result = (CharacterDataWrapper)serializer.ReadObject(ms);

            return result;
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

            // Call out to Marvel
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            // Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(ComicDataWrapper));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (ComicDataWrapper)serializer.ReadObject(ms);
            return result;
        }

        private static string MakeAHash(string timeStamp)
        {
            
            var toBeHashed = timeStamp + PrivateKey + PublicKey;
            var hashedMessage = ComputeMD5(toBeHashed);
            return hashedMessage;     
        }

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
