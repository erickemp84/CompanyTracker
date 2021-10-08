import React from 'react'
import {Link} from 'react-router-dom';

function Timecards() {
    return (
        <div>
            <h1>This is the Timecards page.</h1>
            <Link to="/">Dashboard</Link>
        </div>
    )
}

export default Timecards;