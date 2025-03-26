# ServiceLearningProject

This app is a self contained app that runs .NET SDK.

To run this web Blazor pages app, you need to run ServiceLearningProject.exe present in publish folder and then access http://localhost:8080.

Everytime a change is done to the application, you need to run the publish command to update the executable file:
dotnet publish -c Release -r win-x64 --self-contained true -o publish