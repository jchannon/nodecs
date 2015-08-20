## NodeCs

This repo provides a Dockerfile based on Microsoft ASP.Net docker image.

It adds to it an installation of nodejs with nodemon and a nuget.config that uses the beta builds from the myget feed.

When used it will restore packages and then watch file changes for `cs` & `json` extensions.

Simply open your dnx app in your favoruite editor, make changes and watch them get executed in docker.

### Usage 

Clone this repo
Run `docker build -t jchannon/nodecs:1.0.0-beta6 .`


Create your dnx app in a directory

`docker run -it -p 5001:5001 -v /mnt/hgfs/Projects/MyApp:/src -w /src jchannon/nodecs:1.0.0-beta6`

Browse to http://localhost:5001

Make a change to a file in your app in your editor

F5 and bingo!
