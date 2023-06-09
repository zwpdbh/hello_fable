module App

open Browser.Dom

// Mutable variable to count the number of times we clicked the button
let mutable count = 0

// Get a reference to our button and cast the Element to an HTMLButtonElement
let myButton =
  document.querySelector (".my-button") :?> Browser.Types.HTMLButtonElement

// Register our listener
myButton.onclick <-
  fun _ ->
    count <- count + 2
    myButton.innerText <- sprintf "You clicked www: %i time(s)" count