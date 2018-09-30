I have implemented the requested stories in an .NET Core API and Angular client app.

You can run the API via Visual Studio as normal. (it should be as port 5001, if not just updated proxy.conf.json in angular app to point to right port.)

To run the angular app, just npm install first & npm start.

It utilises the EntityFramework in Memory facility to support easy prototype implementation however this could be swapped easily for another provider.


I have not implemented configuration for different environments as I did not find that practical in this setting, however am happy to discuss different options and techniques for CI/CD delivery to different environments.

