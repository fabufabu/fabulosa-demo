module App

(**
 The famous Increment/Decrement ported from Elm.
 You can find more info about Emish architecture and samples at https://elmish.github.io/
*)

open Elmish
open Elmish.React
module R = Fable.Helpers.React
open R.Props
open Fabulosa.Button
open Fabulosa.Accordion

// MODEL

type Model = int

type Msg =
| Increment
| Decrement

let init() : Model = 0

// UPDATE

let update (msg:Msg) (model:Model) =
    match msg with
    | Increment -> model + 1
    | Decrement -> model - 1

// VIEW (rendered with React)

let def =
    accordion ([],
      [ Item ([],
          (OptIcon None,
           Header "Header One",
           Body
             [ R.a [] [ R.str "Item One" ]
               R.a [] [ R.str "Item Two" ] ]))
        Item ([],
          (OptIcon None,
           Header "Header One",
           Body
             [ R.a [] [ R.str "Item One" ]
               R.a [] [ R.str "Item Two" ] ])) ])

let view (model:Model) dispatch =

  R.div []
      [ R.button [ OnClick (fun _ -> dispatch Increment) ] [ R.str "+" ]
        R.div [] [ R.str (string model) ]
        R.button [ OnClick (fun _ -> dispatch Decrement) ] [ R.str "-" ]
        def
        button ([], [ R.str "Button" ])]

// App
Program.mkSimple init update view
|> Program.withReact "elmish-app"
|> Program.withConsoleTrace
|> Program.run