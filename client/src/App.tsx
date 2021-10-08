import React from 'react';
import './App.css';
import {BrowserRouter} from 'react-router-dom';
import Dashboard from './Pages/Dashboard';
import Timecards from './Pages/Timecards';
import Jobs from './Pages/Jobs';
import Clients from './Pages/Clients';
import Employees from './Pages/Employees';
import Billables from './Pages/Billables';
import Sidebar from './Components/Sidebar';

function App() {

  return (
    <div className="App">

      <Sidebar />
      
      <BrowserRouter>
        <Dashboard path="/Dashboard" component={Dashboard} />
        <Timecards path="/Timecards" component={Timecards} />
        <Jobs path="/Jobs" component={Jobs} />
        <Clients path="/Clients" component={Clients} />
        <Employees path="/Employees" component={Employees} />
        <Billables path="/Billables" component={Billables} />
      </BrowserRouter>
      
    </div>
  );
}

export default App;
