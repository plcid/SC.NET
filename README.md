# SC.NET
Open Source [SwimCloud](https://swimcloud.com/) Info Extractor Based On Web Scraping

# Intro

SC.NET is a C#-built, open-source SwimCloud data extraction tool designed for individual use. This project is dedicated to providing a powerful web scraping solution tailored specifically for SwimCloud (https://swimcloud.com/), enabling you to effortlessly extract comprehensive swim meet results, athlete profiles, and more. Dive into the world of swimming data with SC.NET, a robust and intuitive library crafted by a single developer.

# Warning

Essentially All Methods In This Library MUST BE AWAITED Because This Library Depends On Web Scraping To Get Results.

# Docs

Learn About The Full Library, How It Works & Some Examples To Help You Implement

## Swimmer (int id -> Within Desired Swimmer's URL)

#### getName() -> System.String
Returns currently set name for swimmer (First + Last).

#### getLocation() -> System.String
Returns location (City, State).

#### getTeam() -> scnet.Team
Constructs new scnet.Team object by Team ID referenced in scraped HTML element.

#### getTeamName() -> System.String
Alternative to getTeam() if you only want the name & not additional team info.

#### getAllTeams() -> List<scnet.Team>
Constructs a list of all teams this swimmer has ever been on

#### getAllTeamNames() -> List<System.String>
Alternative to getAllTeams() if you only want the names & not additional team info.

#### getMostRecentMeet() -> scnet.Meet
Constructs new scnet.Meet object by Team ID referenced in HTML element of most recently completed / attended meet on profile.

#### getAllMeets() -> List<scnet.Meet>
Constructs a list of all meets this swimmer has ever attended / completed

#### getAllMeetNames() -> List<System.String>
Alternative to getAllMeets() if you only want the meet names & not additional meet info.

### scnet.Swimmer Example:
```
using scnet;

Swimmer s = new Swimmer(1); // makes new swimmer object with ID of 1
Console.WriteLine(await s.getName()); // prints out first + last name
Console.WriteLine(await s.getLocation()); // prints registered location
Console.WriteLine(await s.getTeam().Result.getName()); // gets team & prints out current team name (slower than getTeamName())
Console.WriteLine(await s.getTeamName()) // only gets team name instead of making new team object, much faster
```

## Team (int id -> Within Desired Team's URL)

#### getName() -> System.String
Returns currently set name for team.

#### getDescription() -> System.String
Returns associated description of the team on the about page. If no description exists, a message is returned, "No Description Available: " + the error message, which is usually a 404 (can be removed).

#### getTags() -> List<System.String>
Returns all tags associated with team, displayed under title (ex: division).

#### getLogoURL() -> System.String
Returns a System.String representation of the URL representing the logo of the team.

#### getCoverURL() -> System.String
Returns a System.String representation of the URL representing the back cover image of the team.

## Meet (int id -> Within Desired Meet's URL)

#### getName() -> System.String
Returns name of the meet
