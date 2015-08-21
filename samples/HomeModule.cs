namespace Twock
{
    using System;
    using Nancy;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "Hi!";
        }
    }
}
