// Learn more about F# at http://fsharp.org

open System
open Microsoft.Extensions.Configuration
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Http

type Startup() =
    member this.Configure(app: IApplicationBuilder) =
        app.Run(fun context -> context.Response.WriteAsync("Hello from Bits'n milk") )

[<EntryPoint>]
let main argv = 
    let config = ConfigurationBuilder().AddCommandLine(argv).Build()

    let host = WebHostBuilder()
                   .UseKestrel()
                   .UseConfiguration(config)
                   .UseStartup<Startup>()
                   .Build()
    host.Run()
    printfn "Server running!"
    0 // return an integer exit code
