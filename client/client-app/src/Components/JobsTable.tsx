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

    const [Jobs, setJobs] = useState([]);

    useEffect(() => {
        axios.get("http://localhost:5000/api/Job").then(response => {
            console.log(response)
            setJobs(response.data)
            })
    }, [])

    return (
        <TableContainer component={Paper}>
            <Table sx={{ minWidth: 650 }} aria-label="simple table">
                <TableHead>
                    <TableRow>
                        <TableCell>ID</TableCell>
                        <TableCell align="right">Name</TableCell>
                        <TableCell align="right">Location</TableCell>
                        <TableCell align="right">Customer</TableCell>
                    </TableRow>
                </TableHead>
                <TableBody>
                    {Jobs.map((Job: any) => (
                        <TableRow
                            key={Job.id}
                            sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
                        >
                            <TableCell component="th" scope="row">
                                {Job.id}
                            </TableCell>
                            <TableCell align="right">{Job.name}</TableCell>
                            <TableCell align="right">{Job.location}</TableCell>
                            <TableCell align="right">{Job.customer}</TableCell>
                        </TableRow>
                    ))}
                </TableBody>
            </Table>
        </TableContainer>
    );
}
