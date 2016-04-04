# Comic-Book-App-Windows10C-
#Overview
The ComicBookApp is an app developed to access the Marvel Api and retieve data. The data is then displayed on a Xmal page so the user can
find out some intresting information about there favourate Marvel Characters. The information is sent back from the API in Json 
 Format and is then deserializered and placed into C# classes. The classes are stored in the Models folder and it contains the 
 classes CharacterDataWrapper, ComicDataWrapper, CreatorDataWrapper. The DataFacade class is where all the Magic happens. 
 The call to the API is made using the GetCharacterDataWrapper(), GetComicDataWrapper(), GetCreatorDataWrapper() methods. 
 In these methods the Url is stored and the hash is created. The HttpClient is used to send and recieve Http requests. 
 This package was downloaded from the NuGet Package Manager. The PopulateMarvelCreatorAsync(), PopulateMarvelComicsAsync(), 
 PopulateMarvelCharactherAsync() methods are used to filter the data which does not have a thumbnail picture, and add it to an Observable 
 Collection. In the UI I used a Hamburger Navigation style to display the information. The Navigate method is used to navigate between 
 pages. Each C# class in the models folder has a Xmal page which is used to display the information. 
 ```c#
 MyFrame.Navigate(typeof(ComicView));
 ````
##Authorizartion
In order to access the Marvel API you must adhere to MD5 Authorizartion which uses a combination of the 
timeStamp + PrivateKey + PublicKey. Every request to the API must have an individualy created MD5 hash.
[Marvel API Instructions](http://developer.marvel.com/documentation/authorization)
##Credits and Acknowledgements 
I followed a tutorial on microsoft accademy in which I learned how acces the API
<https://mva.microsoft.com/en-us/training-courses/windows-10-development-for-absolute-beginners-14541?l=GP9hzBDrB_9405632527> 
The hamburger navigation and split view I found some use full information at
<http://blog.jerrynixon.com/2015/04/implementing-hamburger-button-with.html> and also at Microsoft Accademy. 
