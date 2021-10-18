import * as React from "react";
import {useState, useEffect} from 'react';
import axios from 'axios';
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";

export default function BasicTable() {

    const [AppUsers, setAppUsers] = useState([]);

    useEffect(() => {
        axios.get("http://localhost:5000/api/AppUser").then(response => {
            console.log(response)
            setAppUsers(response.data)
            })
    }, [])

    return (
        <TableContainer component={Paper}>
            <Table sx={{ minWidth: 650 }} aria-label="simple table">
                <TableHead>
                    <TableRow>
                        <TableCell>First Name</TableCell>
                        <TableCell align="right">Last Name</TableCell>
                        <TableCell align="right">Email</TableCell>
                        <TableCell align="right">Crew</TableCell>
                    </TableRow>
                </TableHead>
                <TableBody>
                    {AppUsers.map((AppUser: any) => (
                        <TableRow
                            key={AppUser.id}
                            sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
                        >
                            <TableCell component="th" scope="row">
                                {AppUser.firstName}
                            </TableCell>
                            <TableCell align="right">{AppUser.lastName}</TableCell>
                            <TableCell align="right">{AppUser.email}</TableCell>
                            <TableCell align="right">{AppUser.crew}</TableCell>
                        </TableRow>
                    ))}
                </TableBody>
            </Table>
        </TableContainer>
    );
}
