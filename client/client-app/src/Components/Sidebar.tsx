import React from 'react';
import Box from '@mui/material/Box';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemButton from '@mui/material/ListItemButton';
import ListItemText from '@mui/material/ListItemText';
import {BrowserRouter as Router, Link} from 'react-router-dom';

const Sidebar = () => {

    return(
    <Router>
        <Box className="sidebar-container" sx={{display: 'flex'}}>
            <Box className="sidebar" sx={{display: 'flex', flex: 1, flexDirection: 'column', height: '100vh', width: 200, background: '#214D4D', color: 'white'}}>
                    <List>
                        
                        <Link to="/" style={{textDecoration: 'none', color: 'white'}}>
                        <ListItem disablePadding>
                            <ListItemButton href="/">
                                <ListItemText primary="Dashboard" />
                            </ListItemButton>
                        </ListItem>
                        </Link>

                        <Link to="/api/Punch" style={{textDecoration: 'none', color: 'white'}}>
                        <ListItem disablePadding>
                            <ListItemButton href="/api/Punch">
                                <ListItemText primary="Timecards" />
                            </ListItemButton>
                        </ListItem>
                        </Link>

                        <Link to="/api/Jobs" style={{textDecoration: 'none', color: 'white'}}>
                        <ListItem disablePadding>
                            <ListItemButton href="/api/Job">
                                <ListItemText primary="Jobs" />
                            </ListItemButton>
                        </ListItem>
                        </Link>

                        <Link to="/api/Customer" style={{textDecoration: 'none', color: 'white'}}>
                        <ListItem disablePadding>
                            <ListItemButton href="/api/Customer">
                                <ListItemText primary="Clients" />
                            </ListItemButton>
                        </ListItem>
                        </Link>

                        <Link to="/api/AppUser" style={{textDecoration: 'none', color: 'white'}}>
                        <ListItem disablePadding>
                            <ListItemButton href="/api/AppUser">
                                <ListItemText primary="Employees" />
                            </ListItemButton>
                        </ListItem>
                        </Link>

                        <Link to="/api/Billables" style={{textDecoration: 'none', color: 'white'}}>
                        <ListItem disablePadding>
                            <ListItemButton href="/api/Billables">
                                <ListItemText primary="Billables" />
                            </ListItemButton>
                        </ListItem>
                        </Link>

                    </List>
            </Box>
        </Box>
    </Router>

    );

}

export default Sidebar;