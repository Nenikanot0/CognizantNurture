import React from "react";
import CohortDetails from "./CohortDetails";
import cohorts from "./cohorts";
import "./App.css";

function App() {
  return (
    <div className="App">
      <h1>Cohorts Details</h1>

      {cohorts.map((cohort) => (
        <CohortDetails key={cohort.id} cohort={cohort} />
      ))}
    </div>
  );
}

export default App;
