import React from 'react';
import Box from '@mui/material/Box';
import {BrowserRouter as Router, Route, Switch} from 'react-router-dom';
import Dashboard from './Dashboard';
import TimecardsTable from './TimecardsTable';
import JobsTable from './JobsTable';
import CustomerTable from './CustomerTable';
import AppUsersTable from './AppUsersTable';
import BillablesTable from './BillablesTable';
import SignIn from './SignIn';

const Content = () => {

    return(
        
            <Box sx={{display: 'flex', flex: 4, height: '100vh', backgroundColor: "white"}}>
                <Box sx={{height: 100, width: '100%', backgroundColor: 'white', color: 'black'}}>
                    <Router>
                        <Switch>
                            <Route path="/api/Punch"><TimecardsTable /></Route>
                            <Route path="/api/Job"><JobsTable /></Route>
                            <Route path="/api/Customer"><CustomerTable /></Route>
                            <Route path="/api/AppUser"><AppUsersTable /></Route>
                            <Route path="/api/Billables"><BillablesTable /></Route>
                            <Route path="/signin"><SignIn /></Route>
                            <Route exact path="/"><Dashboard /></Route>
                        </Switch>
                    </Router>
                </Box>
            </Box>

    );

}

export default Content;