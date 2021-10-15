import React from 'react';
import './App.css';
import {BrowserRouter as Router, Switch, Route, Link} from 'react-router-dom';
import Button from "@mui/material/Button";
import Dashboard from './Components/Dashboard';
import TimecardsTable from './Components/TimecardsTable';
import JobsTable from './Components/JobsTable';
import CustomerTable from './Components/CustomerTable';
import AppUsersTable from './Components/AppUsersTable';
import BillablesTable from './Components/BillablesTable';

function App() {

  return (

    <>
      <Router>
        <Link to="/"><Button variant="contained">Dashboard</Button></Link>
        <Link to="/api/Timecards"><Button variant="contained">Timecards</Button></Link>
        <Link to="/api/Job"><Button variant="contained">Jobs</Button></Link>
        <Link to="/api/Customer"><Button variant="contained">Clients</Button></Link>
        <Link to="/api/AppUser"><Button variant="contained">Employees</Button></Link>
        <Link to="/api/Billables"><Button variant="contained">Billables</Button></Link>
        <Switch>
            <Route exact path="/" component={Dashboard} />
            <Route exact path="/api/Timecards" component={TimecardsTable} />
            <Route exact path="/api/Job" component={JobsTable} />
            <Route exact path="/api/Customer" component={CustomerTable} />
            <Route exact path="/api/AppUser" component={AppUsersTable} />
            <Route exact path="/api/Billables" component={BillablesTable} />
        </Switch>
      </Router>
  </>

  );
}

export default App;
