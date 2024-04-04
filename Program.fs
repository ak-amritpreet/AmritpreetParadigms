// Define discriminated union for Categorys
type Category =
    | Thriller
    | Comedy
    | Fantasy
    | Sport
    | Horror
    | Drama
   

// Define movieZ_Director record type
type movieZ_Director = { Name: string; movieZs: int }

// Define movieZ record type
type movieZ = {
    Category: Category
    movieZ_Director: movieZ_Director
    IMDBRating: float
    Name: string
    RunLength: int
   }

// Function to convert minutes to hours and minutes format
let timeConversion (minutes: int) =
    let hours = minutes / 60
    let mins = minutes % 60
    sprintf "%dh %dmin" hours mins

// Create movieZ instances
let movieZs = [
    { Name = "CODA"; RunLength = 111; Category = Drama; movieZ_Director = { Name = "Sian Heder"; movieZs = 9 }; IMDBRating = 8.1 }
    { Name = "Belfast"; RunLength = 98; Category = Comedy; movieZ_Director = { Name = "Kenneth Branagh"; movieZs = 23 }; IMDBRating = 7.3 }
    { Name = "Don’t Look Up"; RunLength = 138; Category = Comedy; movieZ_Director = { Name = "Adam McKay"; movieZs = 27 }; IMDBRating = 7.2 }
    { Name = "Drive My Car"; RunLength = 179; Category = Drama; movieZ_Director = { Name = "Ryusuke Hamaguchi"; movieZs = 16 }; IMDBRating = 7.6 }
    { Name = "Dune"; RunLength = 155; Category = Fantasy; movieZ_Director = { Name = "Denis Villeneuve"; movieZs = 24 }; IMDBRating = 8.1 }
    { Name = "King Richard"; RunLength = 144; Category = Sport; movieZ_Director = { Name = "Reinaldo Marcus Green"; movieZs = 15 }; IMDBRating = 7.5 }
    { Name = "Licorice Pizza"; RunLength = 133; Category = Comedy; movieZ_Director = { Name = "Paul Thomas Anderson"; movieZs = 49 }; IMDBRating = 7.4 }
    { Name = "Nightmare Alley"; RunLength = 150; Category = Thriller; movieZ_Director = { Name = "Guillermo Del Toro"; movieZs = 22 }; IMDBRating = 7.1 }
]

// Identify probable Oscar winners
let winner_Possibility = List.filter (fun movieZ -> movieZ.IMDBRating > 7.4) movieZs

// Convert run length to hours and minutes format
let runTimemovieZ = List.map (fun movieZ -> (movieZ.Name, timeConversion movieZ.RunLength)) movieZs

// Output results
printfn "Probable Oscar Winners - "
winner_Possibility |> List.iter (fun movieZ -> printfn "%s - %.1f" movieZ.Name movieZ.IMDBRating)
printfn "\nmovieZ Run Times:"
runTimemovieZ |> List.iter (fun (name, runtime) -> printfn "%s: %s" name runtime)
