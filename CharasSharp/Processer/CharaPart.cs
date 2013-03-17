using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharasSharp.Processer
{
    public struct CharaPart
    {
        private string imageName;
        private string partName;
        private string authorName;
        private string description;

        public CharaPart(string imageName, string partName, string authorName, string description)
        {
            this.imageName = imageName;
            this.partName = partName;
            this.authorName = authorName;
            this.description = description;
        }

        public string ImageName
        {
            get { return imageName; }
        }

        public string PartName
        {
            get { return partName; }
        }

        public string AuthorName
        {
            get { return authorName; }
        }

        public string Description
        {
            get { return description; }
        }
    }
}
