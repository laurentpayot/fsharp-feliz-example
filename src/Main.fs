module Main

open App
open Elmish

#if DEBUG
open Elmish.HMR // must be after all the other Elmish imports
#endif

Program.mkProgram init update view
|> Program.withReactSynchronous "feliz-app"
|> Program.run
