import React from 'react';
import './App.css';
// import {useState, useEffect} from 'react';
// import axios from 'axios';
// import AppUsersTable from './Components/AppUsersTable';
import JobsTable from './Components/JobsTable';

function App() {
  
  // const [AppUsers, setAppUsers] = useState([]);

  // useEffect(() => {
  //   axios.get('http://localhost:5000/api/AppUser').then(response => {
  //     console.log(response)
  //     setAppUsers(response.data);
  //   })
  // }, [])

  return (

    // <AppUsersTable />
    <JobsTable />

    // <>
    //   <table>
    //     <th>
    //       <td>First Name:</td>
    //       <td>Last Name:</td>
    //       <td>ID:</td>
    //     </th>
    //   </table>
    //   {AppUsers.map((AppUser: any) => (
    //     <table>
    //       <tr>
    //         <th>
    //           <td key={AppUser.id}>{AppUser.firstName}</td>
    //           <td key={AppUser.id}>{AppUser.lastName}</td>
    //           <td key={AppUser.id}>{AppUser.id}</td>
    //         </th>
    //       </tr>
    //   </table>
    //   ))}
    // </>

  );
}

export default App;
