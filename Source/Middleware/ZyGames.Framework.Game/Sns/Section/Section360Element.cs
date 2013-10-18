﻿/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using ZyGames.Framework.Common;

namespace ZyGames.Framework.Game.Sns.Section
{
    public class Section360Element : ConfigurationElement
    {
        [ConfigurationProperty("url", IsRequired = true)]
        public string Url
        {
            get { return this["url"] as string; }
            set { this["url"] = value; }
        }

        [ConfigurationProperty("aceess_token_url", IsRequired = true)]
        public string AceessTokenUrl
        {
            get { return this["aceess_token_url"] as string; }
            set { this["aceess_token_url"] = value; }
        }

        [ConfigurationProperty("get_aceess_token_url", IsRequired = true)]
        public string GetAceessTokenUrl
        {
            get { return this["get_aceess_token_url"] as string; }
            set { this["get_aceess_token_url"] = value; }
        }
        //[ConfigurationProperty("version", IsRequired = true)]
        //public string Version
        //{
        //    get { return this["version"] as string; }
        //    set { this["version"] = value; }
        //}

        //[ConfigurationProperty("type", IsRequired = true)]
        //public int OrderType
        //{
        //    get { return this["type"].ToInt(); }
        //    set { this["type"] = value; }
        //}

        [ConfigurationProperty("", IsDefaultCollection = true)]
        public Channel360Collection Channels
        {
            get { return (Channel360Collection)this[""]; }
        }

    }
}