# WebAssemblyDemo (sorry for the typo in the repo name)

## Used 3rd party library

https://github.com/Elringus/DotNetJS


## Compile

Install .Net 6. Open command prompt, cd to WebAssemplyDemo\WebAssemblyTest run 

`
dotnet publish
`

Copy dotnet.d.ts and dotnet.js from WebAssemplyDemo\WebAssemblyTest\WebAssemblyTest\bin to WebAssemplyDemo\src\assets

![image](https://user-images.githubusercontent.com/116626542/199375002-91b5b794-6db6-4177-8c56-d1a0edd2f2ee.png)



## Run

Go to root directory WebAssemplyDemo

Run angular project in the command prompt with
`
ng serve -o
`
Open Console in browser and click test button
![image](https://user-images.githubusercontent.com/116626542/199375419-f5dd3b81-4ead-4e16-9939-42e92bedfded.png)

## How to expose C# method:

1. C# project should use Microsoft.NET.Sdk.BlazorWebAssembly sdk and add project reference DotNetJS
![image](https://user-images.githubusercontent.com/116626542/199376015-81aa76ea-7233-451a-a697-866422966cf2.png)

2. Create a static main entry point, add [JSInvokable] attribute on the method
![image](https://user-images.githubusercontent.com/116626542/199376289-28d067f3-f3a5-4546-8763-4fd4b0bcf02f.png)

3. Booting dotnet runtime in the index.html
![image](https://user-images.githubusercontent.com/116626542/199376748-54544679-29fb-4262-8349-03ff101ca4ed.png)

4. Invoke method in the angular app.component.ts
![image](https://user-images.githubusercontent.com/116626542/199376970-12e2187e-f5e0-4dec-800b-d2121d03ae0d.png)

