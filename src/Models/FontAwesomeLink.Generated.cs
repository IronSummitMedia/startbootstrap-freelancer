// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery.Abstractions;

namespace StartBootstrap.Freelancer.Blazor.Models
{
    public partial class FontAwesomeLink
    {
        public const string Codename = "font_awesome_link";
        public const string FaCodenameCodename = "fa_codename";
        public const string UrlCodename = "url";
        public const string TextCodename = "text";

        public string FaCodename { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}