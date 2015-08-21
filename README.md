## NodeCs

This repo provides a Dockerfile based on Microsoft ASP.Net docker image.

It adds to it an installation of nodejs with nodemon and a nuget.config that uses the beta builds from the myget feed.

When using this Dockerfile it will restore your app's packages and then watch file changes for `cs` & `json` extensions.

Simply open your dnx app in your favourite editor, make changes and watch them get executed in docker.

### Usage

* Clone this repo
* Move to the relevant version directory
* Run `docker build -t jchannon/nodecs:1.0.0-beta6 .`
* Move to the samples directory
* **NOTE : ** On OSX/Windows you have to create a folder share between your docker host vm and your host OS
* Run `docker run -it -p 5001:5001 -v /mnt/hgfs/Projects/MyApp:/src -w /src jchannon/nodecs:1.0.0-beta6`
* Browse to http://localhost:5001
* Make a change to a file in your app in your editor
* Go to your borwser, press F5 and bingo!
