# Introduction to Asp.Net and WebForms

## Installing IIS
Internet Information Services is Microsoft's web server. On most windows installations it is turned off by default. To turn it on:
* In Control Panel go into Turn Windows Features On/Off and activate Internet Information Services and under it make sure World Wide Web Services->Application Development Features->ASP.NET is selected
* In a command prompt navigate to C:\Windows\Microsoft.NET\Framework64\v4.0.30319 (Framework for 32bit) and run: `aspnet_regiis.exe -i`

## How web servers work
[How web servers work](https://developer.mozilla.org/en-US/Learn/What_is_a_web_server)

Clients (browsers) and web servers communicate over the network through the HTTP protocol:
* HTTP is textual
* HTTP is stateless
* Only clients can initiate communication by making HTTP requests to the server. Servers can only respond to HTTP requests

Browsers can understand only HTML and javascript
* Static pages are html pages that are stored on the server and are sent to the client as-is
* Dynamic pages are pages whose html is generated dynamically before being sent to the client

## Asp.Net
[Asp.Net Overview](https://msdn.microsoft.com/en-us/library/4w3ex9c2.aspx)

Asp.Net is .Net's framework for web development. It has three main approaches for developing web sites:
* Web Forms - uses web pages and controls in them and uses events, much like Windows Forms and WPF applications. We'll start with this approach
* MVC - this is a newer approach, designed to separate code from representation
* Web Pages - these are for casual development, rarely used by professional developers

## Asp.Net Web Forms
* [Introduction to Web Forms](https://msdn.microsoft.com/en-us/library/ms973868.aspx)
* There are two types of controls:
  * HTML controls - ordinary html controls, that can be added a runat="server" attribute and can support only two events: `OnServerClick`, `OnServerChange`
  * Web controls - richer controls that support more features. At run time they are rendered as html controls as well.
* [Page lyfecycle](http://www.codeproject.com/Articles/667596/ASP-NET-Life-Cycle-Overview)
* [State management](https://msdn.microsoft.com/en-us/library/50x35554%28v=vs.80%29.aspx)
  * View State
  * Session State
  * Application State
  * Cookies
* [Web Forms databinding expressions](https://msdn.microsoft.com/en-us/library/bda9bbfx%28v=vs.71%29.aspx), [examples (see the second column)](http://haacked.com/archive/2011/01/06/razor-syntax-quick-reference.aspx/) and [here](http://weblogs.asp.net/ahmedmoosa/embedded-code-and-inline-server-tags)
* Web Forms data binding controls
* [Validators](http://www.codemag.com/article/0307101). In order for unobtrusive validation mode to work you should install jquery and add the following code in Application_start() in Global.asax:
```csharp
ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
                new ScriptResourceDefinition
                {
                    Path = "~/scripts/jquery-2.2.0.min.js",
                    DebugPath = "~/scripts/jquery-2.2.0.js",
                    CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.2.0.min.js",
                    CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.2.0.js"
                });
```

## Working with IIS
[How IIS processes requests](http://abhijitjana.net/2010/03/14/beginner%E2%80%99s-guide-how-iis-process-asp-net-request/)

[Working with IIS](https://msdn.microsoft.com/en-us/library/aa544790%28v=cs.70%29.aspx)
