module Router

open Fable.Import
open Fable.Helpers.React.Props
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser

type Page =
    | Home

let private toHash page =
    match page with
    | Home -> "#/"

let pageParser: Parser<Page->Page,Page> =
    oneOf [ ]

let href route =
    Href (toHash route)

let modifyUrl route =
    route |> toHash |> Navigation.modifyUrl

let newUrl route =
    route |> toHash |> Navigation.newUrl

let modifyLocation route =
    Browser.window.location.href <- toHash route
