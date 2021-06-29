# PingBoardApiClient
[![Build](https://github.com/Johnmancini30/PingboardApiClient/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Johnmancini30/PingboardApiClient/actions/workflows/dotnet.yml)

PingboardApiClient is a client for [Pingboard Api version 2](https://pingboard.docs.apiary.io/) that targets .Net Core 5.0

### Features
* Authentication refresh is handled internally
* Retry policy from Polly is applied to http requests
* Fully async
* Thread safe
### How to use
```
var optionalClient = new HttpClient();
var pingboardClient = new PingboardClient(
                                "<base_url>", 
                                "<client_id>", 
                                "<client_secret>", 
                                optionalClient);
var users = await pingboardClient.Users.GetUsersAsync();
```
### Bugs or Features
Please submit any bug reports or feature requests and I will try to implement them ASAP. Additionally, please submit a PR if that's easier.

Design is heavily inspired by [GitLabApiClient](https://github.com/nmklotas/GitLabApiClient)