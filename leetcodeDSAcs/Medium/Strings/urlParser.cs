using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium.Strings
{
    public class QueryParser
    {
        //public static object Run(string url)
        //{
        //    object output = new object();
        //    StringBuilder sb;

        //    int i = 1;
        //    while (i < url.Length)
        //    {
        //        sb = new StringBuilder();
        //        //object kv = ParseKv(url, sb, i);
        //    }
        //}

        //private static object ParseKv(string url, StringBuilder sb, int i)
        //{
        //    StringBuilder sbKey = new StringBuilder();
        //    StringBuilder sbVal = new StringBuilder();
        //    while (url[i] != '=')
        //    {
        //        sbKey.Append(url[i]);
        //        ++i;
        //    }
        //    ++i; // skip over =
        //    while (url[i] != '&')
        //    {
        //        sbVal.Append(url[i]);
        //        ++i;
        //    }
        //    ++i; // skip over &
        //    string key = sbKey.ToString();
        //    string val = sbVal.ToString();
        //    object key
        //}
    }
}

// "?foo=one&bar=two&baz=three" -> 
// {
//  "foo": "one",
//  "bar": "two",
//  "baz": "three"
// }
// every input begins with "?"