import React from 'react';
import {createUseStyles} from 'react-jss';
import {Link} from 'react-router-dom';

const useStyles = createUseStyles({
    sidebar: {
        height: "100vh",
        width: "300px",
        background: "#214D4D",
        display: "flex",
        alignItems: "center",
        justifyContent: "center",
        color: "white"
    },
    links: {
        fontSize: 25,
        listStyleType: "none",
        textDecoration: "none",
        justifyContent: "space-between",
        lineHeight: 3
    }
})

const Sidebar = () => {

    const classes = useStyles();

    return (
        <div className={classes.sidebar}>
            <ul className={classes.links}>
                <li><Link to="/">Dashboard</Link></li>
                <li><Link to="/Timecards">Timecards</Link></li>
                <li><Link to="/Jobs">Jobs</Link></li>
                <li><Link to="/Clients">Clients</Link></li>
                <li><Link to="/Employees">Employees</Link></li>
                <li><Link to="/Billables">Billables</Link></li>
            </ul>
        </div>
    )
}

export default Sidebar;