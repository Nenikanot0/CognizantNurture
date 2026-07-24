import ListofPlayers from "./ListofPlayers";
import ScoreBelow70 from "./ScoreBelow70";
import { players } from "./players";

import IndianTeam, { OddPlayers, EvenPlayers } from "./IndianPlayers";

import ListofIndianPlayers, { IndianPlayers } from "./ListofIndianPlayers";

function App() {
  let flag = false;

  if (flag === true) {
    return (
      <div>
        <h1>List of Players</h1>

        <ListofPlayers players={players} />

        <hr />

        <h1>List of Players having Scores Less than 70</h1>

        <ScoreBelow70 players={players} />
      </div>
    );
  }

  return (
    <div>
      <h1>Odd Players</h1>

      {OddPlayers(IndianTeam)}

      <hr />

      <h1>Even Players</h1>

      {EvenPlayers(IndianTeam)}

      <hr />

      <h1>List of Indian Players Merged:</h1>

      <ListofIndianPlayers IndianPlayers={IndianPlayers} />
    </div>
  );
}

export default App;
