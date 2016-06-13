# signalR
realTime notification system

Background
In earlier ASP.NET applications, user refreshes a web page to see new data or a page uses "long polling" to retrieve new data, i.e., when new data arrives to server it will not be directly transmitted to all clients or specific clients, for that the user has to refresh the page, and the page will be updated.

For example, you can go to cricinfo.com, there you can see a page is refreshed for 1 or 2 seconds and many times you see the score is not updated. In such situations there is the need of the new Microsoft API called "SignalR".

What is SignalR
SignalR is a new developer's API provided for ASP.NET web applications, used to add "real time" web functionality to ASP.NET applications. "Real Time" web functionality is the ability to have server code to push contents to connected clients.

SignalR supports "server push" or "broadcasting" functionality. It handles connection management automatically. In classic HTTP connections for client-server communication connection is re-established for each request, but SignalR provides persistent connection between the client and the server. In SignalR the server code calls out to a client code in the browser using Remote Procedure Calls (RPC), rather than request-response model today. SignalR is an open-source API, and is accessible through GitHub.

Where to use:

Chat room applications
Real-time monitoring applications
Job progress updates
Real time forms

SignalR provides two models for communication:

Persistent Connections
The Persistent Connection API gives developer direct access to the low level communication protocol that SignalR exposes. This API uses the format of the actual message sent that needs to be specified and if the developer prefers to work with messaging and dispatching model rather than a remote invocation.

Hubs:
It's a High Level API written over PersistentConnection. This API allows the client and server to call methods on each other directly. Hubs also allow you to pass strongly typed parameters to methods, enabling model binding.
