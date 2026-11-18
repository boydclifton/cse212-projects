using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;

public static class SetsAndMaps
{
    
    public static string[] FindPairs(string[] words)
    {
        var seenWords = new HashSet<string>();
        var result = new List<string>();

        foreach (var word in words)
        {
            if (word.Length == 2)
            {
                string reverse = "" + word[1] + word[0];
                if (seenWords.Contains(reverse))
                {
                    result.Add($"{reverse} & {word}");
                }
                seenWords.Add(word);
            }
        }

        return result.ToArray();
    }

    
    public static Dictionary<string, int> SummarizeDegrees(string filename)
    {
        var degrees = new Dictionary<string, int>();
        foreach (var line in File.ReadLines(filename))
        {
            var fields = line.Split(",");
            var degree = fields[3];
            if (!degrees.ContainsKey(degree))
            {
                degrees[degree] = 1;
            }
            else
            {
                degrees[degree]++;
            }
        }

        return degrees;
    }

    
    public static bool IsAnagram(string word1, string word2)
    {
        word1 = word1.ToLower().Replace(" ", "");
        word2 = word2.ToLower().Replace(" ", "");

        if (word1.Length != word2.Length)
        {
            return false;
        }

        var myDict = new Dictionary<char, int>();

        foreach (char letter in word1)
        {
            if (!myDict.ContainsKey(letter))
            {
                myDict[letter] = 1;
            }
            else
            {
                myDict[letter]++;
            }
        }

        foreach (char letter in word2)
        {
            if (!myDict.ContainsKey(letter))
            {
                return false;
            }

            myDict[letter]--;

            if (myDict[letter] < 0)
            {
                return false;
            }
        }

        return true;
    }

    
    public static string[] EarthquakeDailySummary()
    {
        const string uri = "https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson";
        using var client = new HttpClient();
        using var getRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
        using var jsonStream = client.Send(getRequestMessage).Content.ReadAsStream();
        using var reader = new StreamReader(jsonStream);
        var json = reader.ReadToEnd();
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        var featureCollection = JsonSerializer.Deserialize<FeatureCollection>(json, options);

        var summaryList = new List<string>();

        if (featureCollection?.Features != null)
        {
            foreach (var feature in featureCollection.Features)
            {
                string place = feature.Properties.Place;
                double mag = feature.Properties.Mag;
                summaryList.Add($"{place} - Mag {mag}");
            }
        }

        return summaryList.ToArray();
    }
}


public static class FindPairsMethods
{
    public static string[] FindPairs(int[] numbers)
    {
        var result = new List<string>();
        var valuesSeen = new HashSet<int>();

        foreach (var x in numbers)
        {
            int partner = 10 - x;

            if (valuesSeen.Contains(partner))
            {
                result.Add($"{partner}, {x}");
            }

            valuesSeen.Add(x);
        }

        return result.ToArray();
    }
}