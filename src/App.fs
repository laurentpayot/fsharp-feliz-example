module App

open Feliz
open Elmish

type Model = { count: int }

type Msg =
    | Increment
    | Decrement

let init () = { count = 0 }, Cmd.none

let update (msg: Msg) (model: Model) =
    match msg with
    | Increment -> { model with count = model.count + 1 }, Cmd.none
    | Decrement -> { model with count = model.count - 1 }, Cmd.none

let view (model: Model) (dispatch: Msg -> unit) =
    Html.div [
        Html.h1 "Fable + Elmish + Feliz"
        Html.button [ prop.onClick (fun _ -> dispatch Increment); prop.text "Increment" ]

        Html.button [ prop.onClick (fun _ -> dispatch Decrement); prop.text "Decrement" ]

        Html.h1 model.count
    ]
