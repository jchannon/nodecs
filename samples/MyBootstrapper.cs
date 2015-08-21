using System;
using System.IO;
using System.Reflection;
using Nancy;

namespace Twock
{
    public class MyBootstrapper : DefaultNancyBootstrapper
    {
        protected override IRootPathProvider RootPathProvider
        {
            get { return new MyRootPathProvider(); }
        }
    }

    public class MyRootPathProvider : IRootPathProvider
    {
        public string GetRootPath()
        {
            return Directory.GetCurrentDirectory(); 
        }
    }
}
