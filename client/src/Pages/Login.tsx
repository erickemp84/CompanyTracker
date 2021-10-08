import React from 'react'
import {Link} from 'react-router-dom';

function Login() {
    return (
        <div>
            This is the Login page.
            <br></br>
            <br></br>
            <Link to="/Dashboard">Dashboard</Link>
        </div>
    )
}

export default Login;
