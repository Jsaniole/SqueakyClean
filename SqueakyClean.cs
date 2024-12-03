//Implement a partial set of utility routes to help a developer clean up identifier names
//A valid identifier comprises zero or more letters and underscores. 
// If an empty string is passed to the Clean function, an empty string should be returned. 
// Task 1-- Replace the spaces with underscores i.e  a.find the spaces  b.replace the spaces with underscores 
// Task 2-- Replace control characters with the uppercase string CTRL i.e a.find the control characters  b.replace them with "CTRL" (Regex seems suitable)
// Task 3-- Convert kebab-case to camelCase a.Analyze to check if its in kebab-case b.Change to camelCase (remove the hyphen and change the first letter after to uppercase)
// Task 4-- Omit Characters that are not letters i.e a.Take note of the non-letter characters that you've previously added
// Task 5-- Omit Greek Lower Case Letters 
using System;
using System.Text.RegularExpressions;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        identifier = identifier.Replace(" ", "_");
        identifier = Regex.Replace(identifier, @"\p{Cc}", "CTRL");
        identifier = Regex.Replace(identifier, @"-(\p{L})", match => match.Groups[1].Value.ToUpper());
        identifier = Regex.Replace(identifier, @"[^\p{L}_]", string.Empty);
        identifier = Regex.Replace(identifier, "[\u03B1-\u03C9]", string.Empty);
        return identifier;
    }
}