# Running C# programs from CMD

Here we will look how we can run a C# program from command prompt itself.

1. Install .Net Framework in your machine from [here](https://dotnet.microsoft.com/download/dotnet-framework)
2. Note down the installation location in your local machine, generally it is at: `C:\Windows\Microsoft.NET\Framework\v4.0.30319`
3. Open the `This PC` or `My Computer` -> right click to go to `Properties` -> click on `Advanced System Settings` -> in the `Advanced` tab, go to `Environment Variables` -> in `System variables`, select `Path` and click `Edit` -> Click `New` and paste the framework location you noted earlier here. -> Press `OK` and close all the dialog boxes accordingly.
4. Now we are ready to execute any C# program from command prompt
   - Open CMD
   - Type `csc` and press enter, you will receive something like this
   - ![testing in command prompt](./images/3.png)
