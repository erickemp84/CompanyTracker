import React, {useState, useEffect} from 'react';
import axios from 'axios';
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";
import {Billables} from '../Models/Billables';
import Button from '@mui/material/Button';

export default function BillablesTable() {

    const[Billables, setBillables] = useState<Billables[]>([]);

    useEffect(() => {
        axios.get<Billables[]>('http://localhost:5000/api/Billables').then(response => {
            setBillables(response.data)
        })
    }, [])

    return(
        <>
        <TableContainer component={Paper} sx={{width: 800}}>
            <Table sx={{ minWidth: 650 }} aria-label="simple table">
                <TableHead>
                    <TableRow>
                        <TableCell>ID</TableCell>
                        <TableCell align="right">Name</TableCell>
                        <TableCell align="right">Punch</TableCell>
                    </TableRow>
                </TableHead>
                <TableBody>
                    {Billables.map( Billables => (
                        <TableRow
                            key={Billables.id}
                            sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
                        >
                            <TableCell component="th" scope="row">
                                {Billables.id}
                            </TableCell>
                            <TableCell align="right">{Billables.name}</TableCell>
                            <TableCell align="right">{Billables.punch}</TableCell>
                        </TableRow>
                    ))}
                </TableBody>
            </Table>
        </TableContainer>
        <Button variant="contained">Add Billable</Button>
        </>
    );
}