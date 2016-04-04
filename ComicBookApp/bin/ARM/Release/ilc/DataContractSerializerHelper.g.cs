using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 713
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                7, // array length: 7
                1007, // index: 1007, string: "attributionHTML"
                1023, // index: 1023, string: "attributionText"
                1039, // index: 1039, string: "code"
                1044, // index: 1044, string: "copyright"
                1054, // index: 1054, string: "data"
                1059, // index: 1059, string: "etag"
                1064, // index: 1064, string: "status"
                7, // array length: 7
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                5, // array length: 5
                1071, // index: 1071, string: "count"
                1077, // index: 1077, string: "limit"
                1083, // index: 1083, string: "offset"
                1090, // index: 1090, string: "results"
                1098, // index: 1098, string: "total"
                5, // array length: 5
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                11, // array length: 11
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                11, // array length: 11
                1104, // index: 1104, string: "comics"
                1111, // index: 1111, string: "description"
                1123, // index: 1123, string: "events"
                1130, // index: 1130, string: "id"
                1133, // index: 1133, string: "modified"
                1142, // index: 1142, string: "name"
                1147, // index: 1147, string: "resourceURI"
                1159, // index: 1159, string: "series"
                1166, // index: 1166, string: "stories"
                1174, // index: 1174, string: "thumbnail"
                1184, // index: 1184, string: "urls"
                11, // array length: 11
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                1189, // index: 1189, string: "available"
                1199, // index: 1199, string: "collectionURI"
                1213, // index: 1213, string: "items"
                1219, // index: 1219, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                2, // array length: 2
                1142, // index: 1142, string: "name"
                1147, // index: 1147, string: "resourceURI"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                1189, // index: 1189, string: "available"
                1199, // index: 1199, string: "collectionURI"
                1213, // index: 1213, string: "items"
                1219, // index: 1219, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                2, // array length: 2
                1142, // index: 1142, string: "name"
                1147, // index: 1147, string: "resourceURI"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                1189, // index: 1189, string: "available"
                1199, // index: 1199, string: "collectionURI"
                1213, // index: 1213, string: "items"
                1219, // index: 1219, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                2, // array length: 2
                1142, // index: 1142, string: "name"
                1147, // index: 1147, string: "resourceURI"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                1189, // index: 1189, string: "available"
                1199, // index: 1199, string: "collectionURI"
                1213, // index: 1213, string: "items"
                1219, // index: 1219, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                3, // array length: 3
                1142, // index: 1142, string: "name"
                1147, // index: 1147, string: "resourceURI"
                1228, // index: 1228, string: "type"
                3, // array length: 3
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                5, // array length: 5
                1233, // index: 1233, string: "extension"
                1243, // index: 1243, string: "extraLarge"
                1254, // index: 1254, string: "large"
                1260, // index: 1260, string: "path"
                1265, // index: 1265, string: "small"
                5, // array length: 5
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                2, // array length: 2
                1228, // index: 1228, string: "type"
                1271, // index: 1271, string: "url"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                7, // array length: 7
                1007, // index: 1007, string: "attributionHTML"
                1023, // index: 1023, string: "attributionText"
                1039, // index: 1039, string: "code"
                1044, // index: 1044, string: "copyright"
                1054, // index: 1054, string: "data"
                1059, // index: 1059, string: "etag"
                1064, // index: 1064, string: "status"
                7, // array length: 7
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                5, // array length: 5
                1071, // index: 1071, string: "count"
                1077, // index: 1077, string: "limit"
                1083, // index: 1083, string: "offset"
                1090, // index: 1090, string: "results"
                1098, // index: 1098, string: "total"
                5, // array length: 5
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                29, // array length: 29
                -1, // string: null
                613, // index: 613, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                613, // index: 613, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                613, // index: 613, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                29, // array length: 29
                1275, // index: 1275, string: "characters"
                1286, // index: 1286, string: "collectedIssues"
                1302, // index: 1302, string: "collections"
                1314, // index: 1314, string: "creators"
                1323, // index: 1323, string: "dates"
                1111, // index: 1111, string: "description"
                1329, // index: 1329, string: "diamondCode"
                1341, // index: 1341, string: "digitalId"
                1351, // index: 1351, string: "ean"
                1123, // index: 1123, string: "events"
                1355, // index: 1355, string: "format"
                1130, // index: 1130, string: "id"
                1362, // index: 1362, string: "images"
                1369, // index: 1369, string: "isbn"
                1374, // index: 1374, string: "issn"
                1379, // index: 1379, string: "issueNumber"
                1133, // index: 1133, string: "modified"
                1391, // index: 1391, string: "pageCount"
                1401, // index: 1401, string: "prices"
                1147, // index: 1147, string: "resourceURI"
                1159, // index: 1159, string: "series"
                1166, // index: 1166, string: "stories"
                1408, // index: 1408, string: "textObjects"
                1174, // index: 1174, string: "thumbnail"
                1420, // index: 1420, string: "title"
                1426, // index: 1426, string: "upc"
                1184, // index: 1184, string: "urls"
                1430, // index: 1430, string: "variantDescription"
                1449, // index: 1449, string: "variants"
                29, // array length: 29
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                613, // index: 613, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                1189, // index: 1189, string: "available"
                1199, // index: 1199, string: "collectionURI"
                1213, // index: 1213, string: "items"
                1219, // index: 1219, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                1189, // index: 1189, string: "available"
                1199, // index: 1199, string: "collectionURI"
                1213, // index: 1213, string: "items"
                1219, // index: 1219, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                3, // array length: 3
                1142, // index: 1142, string: "name"
                1147, // index: 1147, string: "resourceURI"
                1458, // index: 1458, string: "role"
                3, // array length: 3
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                2, // array length: 2
                1463, // index: 1463, string: "date"
                1228, // index: 1228, string: "type"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                613, // index: 613, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                1189, // index: 1189, string: "available"
                1199, // index: 1199, string: "collectionURI"
                1213, // index: 1213, string: "items"
                1219, // index: 1219, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                2, // array length: 2
                1233, // index: 1233, string: "extension"
                1260, // index: 1260, string: "path"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                2, // array length: 2
                1468, // index: 1468, string: "price"
                1228, // index: 1228, string: "type"
                2, // array length: 2
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                1189, // index: 1189, string: "available"
                1199, // index: 1199, string: "collectionURI"
                1213, // index: 1213, string: "items"
                1219, // index: 1219, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                3, // array length: 3
                1142, // index: 1142, string: "name"
                1147, // index: 1147, string: "resourceURI"
                1228, // index: 1228, string: "type"
                3, // array length: 3
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                3, // array length: 3
                1474, // index: 1474, string: "language"
                1483, // index: 1483, string: "text"
                1228, // index: 1228, string: "type"
                3, // array length: 3
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                5, // array length: 5
                1233, // index: 1233, string: "extension"
                1243, // index: 1243, string: "extraLarge"
                1254, // index: 1254, string: "large"
                1260, // index: 1260, string: "path"
                1265, // index: 1265, string: "small"
                5, // array length: 5
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                7, // array length: 7
                1007, // index: 1007, string: "attributionHTML"
                1023, // index: 1023, string: "attributionText"
                1039, // index: 1039, string: "code"
                1044, // index: 1044, string: "copyright"
                1054, // index: 1054, string: "data"
                1059, // index: 1059, string: "etag"
                1064, // index: 1064, string: "status"
                7, // array length: 7
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                5, // array length: 5
                1071, // index: 1071, string: "count"
                1077, // index: 1077, string: "limit"
                1083, // index: 1083, string: "offset"
                1090, // index: 1090, string: "results"
                1098, // index: 1098, string: "total"
                5, // array length: 5
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                14, // array length: 14
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                14, // array length: 14
                1104, // index: 1104, string: "comics"
                1123, // index: 1123, string: "events"
                1488, // index: 1488, string: "firstName"
                1498, // index: 1498, string: "fullName"
                1130, // index: 1130, string: "id"
                1507, // index: 1507, string: "lastName"
                1516, // index: 1516, string: "middleName"
                1133, // index: 1133, string: "modified"
                1147, // index: 1147, string: "resourceURI"
                1159, // index: 1159, string: "series"
                1166, // index: 1166, string: "stories"
                1527, // index: 1527, string: "suffix"
                1174, // index: 1174, string: "thumbnail"
                1184, // index: 1184, string: "urls"
                14, // array length: 14
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                613, // index: 613, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                1189, // index: 1189, string: "available"
                1199, // index: 1199, string: "collectionURI"
                1213, // index: 1213, string: "items"
                1219, // index: 1219, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                613, // index: 613, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                1189, // index: 1189, string: "available"
                1199, // index: 1199, string: "collectionURI"
                1213, // index: 1213, string: "items"
                1219, // index: 1219, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                613, // index: 613, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                1189, // index: 1189, string: "available"
                1199, // index: 1199, string: "collectionURI"
                1213, // index: 1213, string: "items"
                1219, // index: 1219, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                613, // index: 613, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                4, // array length: 4
                1189, // index: 1189, string: "available"
                1199, // index: 1199, string: "collectionURI"
                1213, // index: 1213, string: "items"
                1219, // index: 1219, string: "returned"
                4, // array length: 4
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                5, // array length: 5
                1233, // index: 1233, string: "extension"
                1243, // index: 1243, string: "extraLarge"
                1254, // index: 1254, string: "large"
                1260, // index: 1260, string: "path"
                1265, // index: 1265, string: "small"
                5, // array length: 5
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276, // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
                276  // index: 276, string: "http://schemas.datacontract.org/2004/07/ComicBookApp.Models"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_dataContractMap_Hashtable = new byte[0];
        // Count=88
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CharacterDataWrapper, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CharacterDataContainer, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Character, ComicBookApp, Version=1.0.0.0, Culture=neutral" +
                                ", PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                "")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Character, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Comics, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Comic, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Comic, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Events, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Event, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Event, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.SeriesList, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Series, ComicBookApp, Version=1.0.0.0, Culture=neutral, P" +
                                "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Series, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Stories, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Story, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Story, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Thumbnail, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Url, ComicBookApp, Version=1.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 82, // 0x52
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Url, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicDataWrapper, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicDataContainer, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.ComicComic, ComicBookApp, Version=1.0.0.0, Culture=neutra" +
                                "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                "a")),
                    TableIndex = 98, // 0x62
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicComic, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Characters, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                "d50a3a")),
                    TableIndex = 114, // 0x72
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Creators, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Creator, ComicBookApp, Version=1.0.0.0, Culture=neutral, " +
                                "PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 130, // 0x82
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Creator, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 289, // 0x121
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Date, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pub" +
                                "licKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 146, // 0x92
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Date, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 305, // 0x131
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicEvents, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 321, // 0x141
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Image, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 162, // 0xa2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Image, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 337, // 0x151
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Price, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 178, // 0xb2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Price, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 353, // 0x161
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicStories, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 369, // 0x171
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.ComicStory, ComicBookApp, Version=1.0.0.0, Culture=neutra" +
                                "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                "a")),
                    TableIndex = 194, // 0xc2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicStory, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 385, // 0x181
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.TextObject, ComicBookApp, Version=1.0.0.0, Culture=neutra" +
                                "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                "a")),
                    TableIndex = 210, // 0xd2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.TextObject, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 401, // 0x191
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicThumbnail, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 417, // 0x1a1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorDataWrapper, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 433, // 0x1b1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorDataContainer, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 449, // 0x1c1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.CreatorCreator, ComicBookApp, Version=1.0.0.0, Culture=ne" +
                                "utral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                "50a3a")),
                    TableIndex = 226, // 0xe2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorCreator, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 465, // 0x1d1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorComics, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 481, // 0x1e1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorEvents, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 497, // 0x1f1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorSeries, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 513, // 0x201
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorStories, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 529, // 0x211
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorThumbnail, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 545, // 0x221
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 242, // 0xf2
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_dataContracts_Hashtable = new byte[0];
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_classDataContracts_Hashtable = new byte[0];
        // Count=35
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // CharacterDataWrapper
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 255, // CharacterDataWrapper
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 255, // CharacterDataWrapper
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CharacterDataWrapper, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CharacterDataWrapper, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 9,
                    MemberNamesListIndex = 11,
                    MemberNamespacesListIndex = 19,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 336, // CharacterDataContainer
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 336, // CharacterDataContainer
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 336, // CharacterDataContainer
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CharacterDataContainer, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CharacterDataContainer, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 27,
                    ContractNamespacesListIndex = 33,
                    MemberNamesListIndex = 35,
                    MemberNamespacesListIndex = 41,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 376, // Character
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 376, // Character
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 376, // Character
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Character, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Character, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 47,
                    ContractNamespacesListIndex = 59,
                    MemberNamesListIndex = 61,
                    MemberNamespacesListIndex = 73,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 386, // Comics
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 386, // Comics
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 386, // Comics
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Comics, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Comics, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 85,
                    ContractNamespacesListIndex = 90,
                    MemberNamesListIndex = 92,
                    MemberNamespacesListIndex = 97,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 406, // Comic
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 406, // Comic
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 406, // Comic
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Comic, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Comic, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 102,
                    ContractNamespacesListIndex = 105,
                    MemberNamesListIndex = 107,
                    MemberNamespacesListIndex = 110,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 412, // Events
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 412, // Events
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 412, // Events
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Events, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Events, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 113,
                    ContractNamespacesListIndex = 118,
                    MemberNamesListIndex = 120,
                    MemberNamespacesListIndex = 125,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 432, // Event
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 432, // Event
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 432, // Event
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Event, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Event, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 130,
                    ContractNamespacesListIndex = 133,
                    MemberNamesListIndex = 135,
                    MemberNamespacesListIndex = 138,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 438, // SeriesList
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 438, // SeriesList
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 438, // SeriesList
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.SeriesList, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.SeriesList, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 141,
                    ContractNamespacesListIndex = 146,
                    MemberNamesListIndex = 148,
                    MemberNamespacesListIndex = 153,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 463, // Series
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 463, // Series
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 463, // Series
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Series, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Series, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 158,
                    ContractNamespacesListIndex = 161,
                    MemberNamesListIndex = 163,
                    MemberNamespacesListIndex = 166,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 470, // Stories
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 470, // Stories
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 470, // Stories
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Stories, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Stories, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 169,
                    ContractNamespacesListIndex = 174,
                    MemberNamesListIndex = 176,
                    MemberNamespacesListIndex = 181,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 491, // Story
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 491, // Story
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 491, // Story
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Story, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Story, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 186,
                    ContractNamespacesListIndex = 190,
                    MemberNamesListIndex = 192,
                    MemberNamespacesListIndex = 196,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 497, // Thumbnail
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 497, // Thumbnail
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 497, // Thumbnail
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Thumbnail, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Thumbnail, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 200,
                    ContractNamespacesListIndex = 206,
                    MemberNamesListIndex = 208,
                    MemberNamespacesListIndex = 214,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 518, // Url
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 518, // Url
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 518, // Url
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Url, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Url, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 220,
                    ContractNamespacesListIndex = 223,
                    MemberNamesListIndex = 225,
                    MemberNamespacesListIndex = 228,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 522, // ComicDataWrapper
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 522, // ComicDataWrapper
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 522, // ComicDataWrapper
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicDataWrapper, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicDataWrapper, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 231,
                    ContractNamespacesListIndex = 239,
                    MemberNamesListIndex = 241,
                    MemberNamespacesListIndex = 249,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 539, // ComicDataContainer
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 539, // ComicDataContainer
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 539, // ComicDataContainer
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicDataContainer, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicDataContainer, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 257,
                    ContractNamespacesListIndex = 263,
                    MemberNamesListIndex = 265,
                    MemberNamespacesListIndex = 271,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 576, // ComicComic
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 576, // ComicComic
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 576, // ComicComic
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicComic, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicComic, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 277,
                    ContractNamespacesListIndex = 307,
                    MemberNamesListIndex = 309,
                    MemberNamespacesListIndex = 339,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 587, // Characters
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 587, // Characters
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 587, // Characters
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Characters, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Characters, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 369,
                    ContractNamespacesListIndex = 374,
                    MemberNamesListIndex = 376,
                    MemberNamespacesListIndex = 381,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 671, // Creators
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 671, // Creators
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 671, // Creators
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Creators, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Creators, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 386,
                    ContractNamespacesListIndex = 391,
                    MemberNamesListIndex = 393,
                    MemberNamespacesListIndex = 398,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 695, // Creator
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 695, // Creator
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 695, // Creator
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Creator, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Creator, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 403,
                    ContractNamespacesListIndex = 407,
                    MemberNamesListIndex = 409,
                    MemberNamespacesListIndex = 413,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 715, // Date
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 715, // Date
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 715, // Date
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Date, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Date, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 417,
                    ContractNamespacesListIndex = 420,
                    MemberNamesListIndex = 422,
                    MemberNamespacesListIndex = 425,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 720, // ComicEvents
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 720, // ComicEvents
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 720, // ComicEvents
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicEvents, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicEvents, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 428,
                    ContractNamespacesListIndex = 433,
                    MemberNamesListIndex = 435,
                    MemberNamespacesListIndex = 440,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 745, // Image
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 745, // Image
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 745, // Image
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Image, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Image, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 445,
                    ContractNamespacesListIndex = 448,
                    MemberNamesListIndex = 450,
                    MemberNamespacesListIndex = 453,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 764, // Price
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 764, // Price
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 764, // Price
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Price, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Price, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 456,
                    ContractNamespacesListIndex = 459,
                    MemberNamesListIndex = 461,
                    MemberNamespacesListIndex = 464,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 770, // ComicStories
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 770, // ComicStories
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 770, // ComicStories
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicStories, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicStories, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 467,
                    ContractNamespacesListIndex = 472,
                    MemberNamesListIndex = 474,
                    MemberNamespacesListIndex = 479,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 801, // ComicStory
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 801, // ComicStory
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 801, // ComicStory
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicStory, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicStory, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 484,
                    ContractNamespacesListIndex = 488,
                    MemberNamesListIndex = 490,
                    MemberNamespacesListIndex = 494,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 830, // TextObject
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 830, // TextObject
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 830, // TextObject
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.TextObject, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.TextObject, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 498,
                    ContractNamespacesListIndex = 502,
                    MemberNamesListIndex = 504,
                    MemberNamespacesListIndex = 508,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 841, // ComicThumbnail
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 841, // ComicThumbnail
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 841, // ComicThumbnail
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicThumbnail, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicThumbnail, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 512,
                    ContractNamespacesListIndex = 518,
                    MemberNamesListIndex = 520,
                    MemberNamespacesListIndex = 526,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 856, // CreatorDataWrapper
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 856, // CreatorDataWrapper
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 856, // CreatorDataWrapper
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorDataWrapper, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorDataWrapper, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 532,
                    ContractNamespacesListIndex = 540,
                    MemberNamesListIndex = 542,
                    MemberNamespacesListIndex = 550,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 875, // CreatorDataContainer
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 875, // CreatorDataContainer
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 875, // CreatorDataContainer
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorDataContainer, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorDataContainer, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 558,
                    ContractNamespacesListIndex = 564,
                    MemberNamesListIndex = 566,
                    MemberNamespacesListIndex = 572,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 918, // CreatorCreator
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 918, // CreatorCreator
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 918, // CreatorCreator
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorCreator, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorCreator, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 578,
                    ContractNamespacesListIndex = 593,
                    MemberNamesListIndex = 595,
                    MemberNamespacesListIndex = 610,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 933, // CreatorComics
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 933, // CreatorComics
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 933, // CreatorComics
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorComics, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorComics, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 625,
                    ContractNamespacesListIndex = 630,
                    MemberNamesListIndex = 632,
                    MemberNamespacesListIndex = 637,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 947, // CreatorEvents
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 947, // CreatorEvents
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 947, // CreatorEvents
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorEvents, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorEvents, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 642,
                    ContractNamespacesListIndex = 647,
                    MemberNamesListIndex = 649,
                    MemberNamespacesListIndex = 654,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 961, // CreatorSeries
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 961, // CreatorSeries
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 961, // CreatorSeries
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorSeries, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorSeries, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 659,
                    ContractNamespacesListIndex = 664,
                    MemberNamesListIndex = 666,
                    MemberNamespacesListIndex = 671,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 975, // CreatorStories
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 975, // CreatorStories
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 975, // CreatorStories
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorStories, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorStories, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 676,
                    ContractNamespacesListIndex = 681,
                    MemberNamesListIndex = 683,
                    MemberNamespacesListIndex = 688,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 990, // CreatorThumbnail
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 990, // CreatorThumbnail
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 990, // CreatorThumbnail
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorThumbnail, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorThumbnail, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 693,
                    ContractNamespacesListIndex = 699,
                    MemberNamesListIndex = 701,
                    MemberNamespacesListIndex = 707,
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_collectionDataContracts_Hashtable = new byte[0];
        // Count=16
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 359, // ArrayOfCharacter
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 359, // ArrayOfCharacter
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 359, // ArrayOfCharacter
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Character, ComicBookApp, Version=1.0.0.0, Culture=neutral" +
                                    ", PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Character, ComicBookApp, Version=1.0.0.0, Culture=neutral" +
                                    ", PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                    "")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 376, // Character
                    KeyNameIndex = -1,
                    ItemNameIndex = 376, // Character
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Character, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 393, // ArrayOfComic
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 393, // ArrayOfComic
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 393, // ArrayOfComic
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Comic, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Comic, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 406, // Comic
                    KeyNameIndex = -1,
                    ItemNameIndex = 406, // Comic
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Comic, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 419, // ArrayOfEvent
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 419, // ArrayOfEvent
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 419, // ArrayOfEvent
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Event, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Event, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 432, // Event
                    KeyNameIndex = -1,
                    ItemNameIndex = 432, // Event
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Event, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 449, // ArrayOfSeries
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 449, // ArrayOfSeries
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 449, // ArrayOfSeries
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Series, ComicBookApp, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Series, ComicBookApp, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 463, // Series
                    KeyNameIndex = -1,
                    ItemNameIndex = 463, // Series
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Series, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 478, // ArrayOfStory
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 478, // ArrayOfStory
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 478, // ArrayOfStory
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Story, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Story, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 491, // Story
                    KeyNameIndex = -1,
                    ItemNameIndex = 491, // Story
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Story, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 507, // ArrayOfUrl
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 507, // ArrayOfUrl
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 507, // ArrayOfUrl
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Url, ComicBookApp, Version=1.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Url, ComicBookApp, Version=1.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 518, // Url
                    KeyNameIndex = -1,
                    ItemNameIndex = 518, // Url
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Url, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 558, // ArrayOfComicComic
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 558, // ArrayOfComicComic
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 558, // ArrayOfComicComic
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.ComicComic, ComicBookApp, Version=1.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                    "a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.ComicComic, ComicBookApp, Version=1.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                    "a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 576, // ComicComic
                    KeyNameIndex = -1,
                    ItemNameIndex = 576, // ComicComic
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicComic, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 598, // ArrayOfanyType
                        NamespaceIndex = 613, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 598, // ArrayOfanyType
                        StableNameNamespaceIndex = 613, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 598, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 613, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 680, // ArrayOfCreator
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 680, // ArrayOfCreator
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 680, // ArrayOfCreator
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Creator, ComicBookApp, Version=1.0.0.0, Culture=neutral, " +
                                    "PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Creator, ComicBookApp, Version=1.0.0.0, Culture=neutral, " +
                                    "PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 695, // Creator
                    KeyNameIndex = -1,
                    ItemNameIndex = 695, // Creator
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Creator, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 703, // ArrayOfDate
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 703, // ArrayOfDate
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 703, // ArrayOfDate
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Date, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Date, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 715, // Date
                    KeyNameIndex = -1,
                    ItemNameIndex = 715, // Date
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Date, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 732, // ArrayOfImage
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 732, // ArrayOfImage
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 732, // ArrayOfImage
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Image, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Image, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 745, // Image
                    KeyNameIndex = -1,
                    ItemNameIndex = 745, // Image
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Image, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 751, // ArrayOfPrice
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 751, // ArrayOfPrice
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 751, // ArrayOfPrice
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Price, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.Price, ComicBookApp, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 764, // Price
                    KeyNameIndex = -1,
                    ItemNameIndex = 764, // Price
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.Price, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 783, // ArrayOfComicStory
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 783, // ArrayOfComicStory
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 783, // ArrayOfComicStory
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.ComicStory, ComicBookApp, Version=1.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                    "a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.ComicStory, ComicBookApp, Version=1.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                    "a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 801, // ComicStory
                    KeyNameIndex = -1,
                    ItemNameIndex = 801, // ComicStory
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.ComicStory, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 812, // ArrayOfTextObject
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 812, // ArrayOfTextObject
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 812, // ArrayOfTextObject
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.TextObject, ComicBookApp, Version=1.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                    "a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.TextObject, ComicBookApp, Version=1.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
                                    "a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 830, // TextObject
                    KeyNameIndex = -1,
                    ItemNameIndex = 830, // TextObject
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.TextObject, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 896, // ArrayOfCreatorCreator
                        NamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        StableNameIndex = 896, // ArrayOfCreatorCreator
                        StableNameNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        TopLevelElementNameIndex = 896, // ArrayOfCreatorCreator
                        TopLevelElementNamespaceIndex = 276, // http://schemas.datacontract.org/2004/07/ComicBookApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.CreatorCreator, ComicBookApp, Version=1.0.0.0, Culture=ne" +
                                    "utral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                    "50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[ComicBookApp.Models.CreatorCreator, ComicBookApp, Version=1.0.0.0, Culture=ne" +
                                    "utral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                    "50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 918, // CreatorCreator
                    KeyNameIndex = -1,
                    ItemNameIndex = 918, // CreatorCreator
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("ComicBookApp.Models.CreatorCreator, ComicBookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 598, // ArrayOfanyType
                        NamespaceIndex = 613, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 598, // ArrayOfanyType
                        StableNameNamespaceIndex = 613, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 598, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 613, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_enumDataContracts_Hashtable = new byte[0];
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_xmlDataContracts_Hashtable = new byte[0];
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_jsonDelegatesList_Hashtable = new byte[0];
        // Count=51
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 37,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type3.WriteCharacterDataWrapperToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type2.ReadCharacterDataWrapperFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 38,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type7.WriteCharacterDataContainerToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type6.ReadCharacterDataContainerFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 39,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type12.WriteArrayOfCharacterToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type11.ReadArrayOfCharacterFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type13.ReadArrayOfCharacterFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 40,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type17.WriteCharacterToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type16.ReadCharacterFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 41,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type21.WriteComicsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type20.ReadComicsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 42,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type26.WriteArrayOfComicToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type25.ReadArrayOfComicFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type27.ReadArrayOfComicFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 43,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type31.WriteComicToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type30.ReadComicFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 44,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type35.WriteEventsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type34.ReadEventsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 45,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type40.WriteArrayOfEventToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type39.ReadArrayOfEventFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type41.ReadArrayOfEventFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 46,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type45.WriteEventToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type44.ReadEventFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 47,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type49.WriteSeriesListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type48.ReadSeriesListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 48,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type54.WriteArrayOfSeriesToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type53.ReadArrayOfSeriesFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type55.ReadArrayOfSeriesFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 49,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type59.WriteSeriesToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type58.ReadSeriesFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type63.WriteStoriesToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type62.ReadStoriesFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 51,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type68.WriteArrayOfStoryToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type67.ReadArrayOfStoryFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type69.ReadArrayOfStoryFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type73.WriteStoryToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type72.ReadStoryFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 53,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type77.WriteThumbnailToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type76.ReadThumbnailFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 54,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type82.WriteArrayOfUrlToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type81.ReadArrayOfUrlFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type83.ReadArrayOfUrlFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 55,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type87.WriteUrlToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type86.ReadUrlFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 56,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type91.WriteComicDataWrapperToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type90.ReadComicDataWrapperFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 57,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type95.WriteComicDataContainerToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type94.ReadComicDataContainerFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 58,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type100.WriteArrayOfComicComicToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type99.ReadArrayOfComicComicFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type101.ReadArrayOfComicComicFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 59,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type105.WriteComicComicToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type104.ReadComicComicFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 60,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type109.WriteCharactersToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type108.ReadCharactersFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 61,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type114.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type113.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type115.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 62,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type119.WriteCreatorsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type118.ReadCreatorsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 63,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type124.WriteArrayOfCreatorToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type123.ReadArrayOfCreatorFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type125.ReadArrayOfCreatorFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 64,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type129.WriteCreatorToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type128.ReadCreatorFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 65,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type134.WriteArrayOfDateToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type133.ReadArrayOfDateFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type135.ReadArrayOfDateFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 66,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type139.WriteDateToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type138.ReadDateFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 67,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type143.WriteComicEventsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type142.ReadComicEventsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 68,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type148.WriteArrayOfImageToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type147.ReadArrayOfImageFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type149.ReadArrayOfImageFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 69,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type153.WriteImageToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type152.ReadImageFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 70,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type158.WriteArrayOfPriceToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type157.ReadArrayOfPriceFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type159.ReadArrayOfPriceFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 71,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type163.WritePriceToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type162.ReadPriceFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 72,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type167.WriteComicStoriesToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type166.ReadComicStoriesFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 73,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type172.WriteArrayOfComicStoryToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type171.ReadArrayOfComicStoryFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type173.ReadArrayOfComicStoryFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 74,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type177.WriteComicStoryToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type176.ReadComicStoryFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 75,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type182.WriteArrayOfTextObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type181.ReadArrayOfTextObjectFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type183.ReadArrayOfTextObjectFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 76,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type187.WriteTextObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type186.ReadTextObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 77,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type191.WriteComicThumbnailToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type190.ReadComicThumbnailFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 78,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type195.WriteCreatorDataWrapperToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type194.ReadCreatorDataWrapperFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 79,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type199.WriteCreatorDataContainerToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type198.ReadCreatorDataContainerFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 80,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type204.WriteArrayOfCreatorCreatorToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type203.ReadArrayOfCreatorCreatorFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type205.ReadArrayOfCreatorCreatorFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 81,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type209.WriteCreatorCreatorToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type208.ReadCreatorCreatorFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 82,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type213.WriteCreatorComicsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type212.ReadCreatorComicsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 83,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type217.WriteCreatorEventsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type216.ReadCreatorEventsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 84,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type221.WriteCreatorSeriesToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type220.ReadCreatorSeriesFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 85,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type225.WriteCreatorStoriesToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type224.ReadCreatorStoriesFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 86,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type229.WriteCreatorThumbnailToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type228.ReadCreatorThumbnailFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 87,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type234.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type233.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type235.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','C','h','a','r','a','c','t','e','r','D','a','t','a','W','r',
            'a','p','p','e','r','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r',
            'a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','C','o','m','i','c','B','o','o','k','A','p','p','.','M',
            'o','d','e','l','s','\0','C','h','a','r','a','c','t','e','r','D','a','t','a','C','o','n','t','a','i','n','e','r','\0','A',
            'r','r','a','y','O','f','C','h','a','r','a','c','t','e','r','\0','C','h','a','r','a','c','t','e','r','\0','C','o','m','i',
            'c','s','\0','A','r','r','a','y','O','f','C','o','m','i','c','\0','C','o','m','i','c','\0','E','v','e','n','t','s','\0','A',
            'r','r','a','y','O','f','E','v','e','n','t','\0','E','v','e','n','t','\0','S','e','r','i','e','s','L','i','s','t','\0','A',
            'r','r','a','y','O','f','S','e','r','i','e','s','\0','S','e','r','i','e','s','\0','S','t','o','r','i','e','s','\0','A','r',
            'r','a','y','O','f','S','t','o','r','y','\0','S','t','o','r','y','\0','T','h','u','m','b','n','a','i','l','\0','A','r','r',
            'a','y','O','f','U','r','l','\0','U','r','l','\0','C','o','m','i','c','D','a','t','a','W','r','a','p','p','e','r','\0','C',
            'o','m','i','c','D','a','t','a','C','o','n','t','a','i','n','e','r','\0','A','r','r','a','y','O','f','C','o','m','i','c',
            'C','o','m','i','c','\0','C','o','m','i','c','C','o','m','i','c','\0','C','h','a','r','a','c','t','e','r','s','\0','A','r',
            'r','a','y','O','f','a','n','y','T','y','p','e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i',
            'c','r','o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t',
            'i','o','n','/','A','r','r','a','y','s','\0','C','r','e','a','t','o','r','s','\0','A','r','r','a','y','O','f','C','r','e',
            'a','t','o','r','\0','C','r','e','a','t','o','r','\0','A','r','r','a','y','O','f','D','a','t','e','\0','D','a','t','e','\0',
            'C','o','m','i','c','E','v','e','n','t','s','\0','A','r','r','a','y','O','f','I','m','a','g','e','\0','I','m','a','g','e',
            '\0','A','r','r','a','y','O','f','P','r','i','c','e','\0','P','r','i','c','e','\0','C','o','m','i','c','S','t','o','r','i',
            'e','s','\0','A','r','r','a','y','O','f','C','o','m','i','c','S','t','o','r','y','\0','C','o','m','i','c','S','t','o','r',
            'y','\0','A','r','r','a','y','O','f','T','e','x','t','O','b','j','e','c','t','\0','T','e','x','t','O','b','j','e','c','t',
            '\0','C','o','m','i','c','T','h','u','m','b','n','a','i','l','\0','C','r','e','a','t','o','r','D','a','t','a','W','r','a',
            'p','p','e','r','\0','C','r','e','a','t','o','r','D','a','t','a','C','o','n','t','a','i','n','e','r','\0','A','r','r','a',
            'y','O','f','C','r','e','a','t','o','r','C','r','e','a','t','o','r','\0','C','r','e','a','t','o','r','C','r','e','a','t',
            'o','r','\0','C','r','e','a','t','o','r','C','o','m','i','c','s','\0','C','r','e','a','t','o','r','E','v','e','n','t','s',
            '\0','C','r','e','a','t','o','r','S','e','r','i','e','s','\0','C','r','e','a','t','o','r','S','t','o','r','i','e','s','\0',
            'C','r','e','a','t','o','r','T','h','u','m','b','n','a','i','l','\0','a','t','t','r','i','b','u','t','i','o','n','H','T',
            'M','L','\0','a','t','t','r','i','b','u','t','i','o','n','T','e','x','t','\0','c','o','d','e','\0','c','o','p','y','r','i',
            'g','h','t','\0','d','a','t','a','\0','e','t','a','g','\0','s','t','a','t','u','s','\0','c','o','u','n','t','\0','l','i','m',
            'i','t','\0','o','f','f','s','e','t','\0','r','e','s','u','l','t','s','\0','t','o','t','a','l','\0','c','o','m','i','c','s',
            '\0','d','e','s','c','r','i','p','t','i','o','n','\0','e','v','e','n','t','s','\0','i','d','\0','m','o','d','i','f','i','e',
            'd','\0','n','a','m','e','\0','r','e','s','o','u','r','c','e','U','R','I','\0','s','e','r','i','e','s','\0','s','t','o','r',
            'i','e','s','\0','t','h','u','m','b','n','a','i','l','\0','u','r','l','s','\0','a','v','a','i','l','a','b','l','e','\0','c',
            'o','l','l','e','c','t','i','o','n','U','R','I','\0','i','t','e','m','s','\0','r','e','t','u','r','n','e','d','\0','t','y',
            'p','e','\0','e','x','t','e','n','s','i','o','n','\0','e','x','t','r','a','L','a','r','g','e','\0','l','a','r','g','e','\0',
            'p','a','t','h','\0','s','m','a','l','l','\0','u','r','l','\0','c','h','a','r','a','c','t','e','r','s','\0','c','o','l','l',
            'e','c','t','e','d','I','s','s','u','e','s','\0','c','o','l','l','e','c','t','i','o','n','s','\0','c','r','e','a','t','o',
            'r','s','\0','d','a','t','e','s','\0','d','i','a','m','o','n','d','C','o','d','e','\0','d','i','g','i','t','a','l','I','d',
            '\0','e','a','n','\0','f','o','r','m','a','t','\0','i','m','a','g','e','s','\0','i','s','b','n','\0','i','s','s','n','\0','i',
            's','s','u','e','N','u','m','b','e','r','\0','p','a','g','e','C','o','u','n','t','\0','p','r','i','c','e','s','\0','t','e',
            'x','t','O','b','j','e','c','t','s','\0','t','i','t','l','e','\0','u','p','c','\0','v','a','r','i','a','n','t','D','e','s',
            'c','r','i','p','t','i','o','n','\0','v','a','r','i','a','n','t','s','\0','r','o','l','e','\0','d','a','t','e','\0','p','r',
            'i','c','e','\0','l','a','n','g','u','a','g','e','\0','t','e','x','t','\0','f','i','r','s','t','N','a','m','e','\0','f','u',
            'l','l','N','a','m','e','\0','l','a','s','t','N','a','m','e','\0','m','i','d','d','l','e','N','a','m','e','\0','s','u','f',
            'f','i','x','\0'};
    }
}
