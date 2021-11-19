import React, {useState, useEffect} from 'react';
import axios from 'axios';
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";
import {Punches} from '../Models/Punches';
import Button from '@mui/material/Button';

export default function TimecardsTable() {

    const [Punch, setPunches] = useState<Punches[]>([]);

        useEffect(() => {
        axios.get<Punches[]>("http://localhost:5000/api/Punch").then(response => {
            setPunches(response.data)
            })
    }, [])

    return(
        <>
        <TableContainer component={Paper} sx={{width: 800}}>
            <Table sx={{ minWidth: 650 }} aria-label="simple table">
                <TableHead>
                    <TableRow>
                        <TableCell>ID:</TableCell>
                        <TableCell align="right">Clock In</TableCell>
                        <TableCell align="right">Clock Out</TableCell>
                        <TableCell align="right">Clock In Location</TableCell>
                        <TableCell align="right">Clock Out Location</TableCell>
                    </TableRow>
                </TableHead>
                <TableBody>
                    {Punch.map( Punch => (
                        <TableRow
                            key={Punch.id}
                            sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
                        >
                            <TableCell component="th" scope="row">
                                {Punch.id}
                            </TableCell>
                            <TableCell align="right">{Punch.id}</TableCell>
                            <TableCell align="right">{Punch.clockIn}</TableCell>
                            <TableCell align="right">{Punch.clockOut}</TableCell>
                            <TableCell align="right">{Punch.clockInLongLat}</TableCell>
                            <TableCell align="right">{Punch.clockOutLongLat}</TableCell>
                        </TableRow>
                    ))}
                </TableBody>
            </Table>
        </TableContainer>
        <Button variant="contained">Add Punch</Button>
        </>

    
    );
}