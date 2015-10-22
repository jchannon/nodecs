# NodeCs

NodeCs is a 'hot reload' Dockerfile to simplify [DNX][] app development. The Dockerfile is based on the
[Microsoft ASP.Net Docker Image][] and adds to it an installation of [Node.js][] along with [nodemon][] and a
nuget.config that uses the beta builds from the [MyGet feed][].

Using this Dockerfile it will restore your app's packages and then watch file changes for `*.cs` and
`*.json` extensions. Simply open your [DNX][] app in your favorite [OmniSharp][] editor, make changes
and watch them get executed in Docker.

## Usage
To get started using this Dockerfile simply follow the steps below:



1. Clone this repo

2. Move to the relevant version directory

3. Run `docker build -t jchannon/nodecs:1.0.0-beta8 .`

4. Move to the samples directory

5. __NOTE :__ On OSX/Windows you must create a folder share between your Docker VM and your OS
(on Windows, you can use the automatically shared folder /c/Users/ )

6. Run `docker run -it -p 5001:5001 -v /mnt/hgfs/Projects/MyApp:/src -w /src jchannon/nodecs:1.0.0-beta8`

Now you can browse to `http://DOCKER_IP:5001` to see your app.

To see 'hot reload' in action:

- Make a change to a file in your app in your editor
- Go to your browser, press F5 and bingo!

## Contributing
NodeCs is an __open project__ and encourages participation. If you feel you can help in any way, be
it with examples, testing, or new features please be our guest.

## License

Copyright Jonathan Channon 2015, Licensed under [MIT][].

[MIT]: ./LICENSE
[DNX]: https://github.com/aspnet/dnx
[Node.js]: https://github.com/nodejs/node
[OmniSharp]: http://www.omnisharp.net/
[nodemon]: https://github.com/remy/nodemon
[MyGet feed]: https://www.myget.org/gallery/aspnetvnext
[Microsoft ASP.Net Docker Image]: https://github.com/aspnet/aspnet-docker
