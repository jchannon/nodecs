## NodeCs

This repo provides a Dockerfile based on Microsoft ASP.Net docker image.

It adds to it an installation of nodejs with nodemon and a nuget.config that uses the beta builds from the myget feed.

When using this Dockerfile it will restore your app's packages and then watch file changes for `cs` & `json` extensions.

Simply open your dnx app in your favourite editor, make changes and watch them get executed in docker.

### Usage

* Download and install the latest version of toolbox ( https://www.docker.com/toolbox )
* Using a Powershell prompt, create your host using `docker-machine.exe create --driver virtualbox YOUR_MACHINE_NAME`
* Then start your host by typing `docker-machine.exe start YOUR_MACHINE_NAME`
* Then register the host details by typing `docker-machine.exe env --shell powershell YOUR_MACHINE_NAME | Invoke-Expression`
* Note the ip of the host, it's your DOCKER_IP
* Clone this repo
* Move to the relevant version directory (beta7 right now)
* Run `docker build -t jchannon/nodecs:1.0.0-beta7 .`
* Move to the samples directory
* **NOTE :** On OSX/Windows you have to create a folder share between your docker host vm and your host OS or on Windows, you can use the automatically shared folder /c/Users/
* Run `docker run -it -p 5001:5001 -v /c/Users/YOUR_PROJECT/MY_APP:/src -w /src jchannon/nodecs:1.0.0-beta7`
* Browse to http://DOCKER_IP:5001
* Make a change to a file in your app in your editor
* Go to your borwser, press F5 and bingo!
