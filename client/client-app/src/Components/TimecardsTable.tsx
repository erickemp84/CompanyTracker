import React, {useState, useEffect} from 'react';
import axios from 'axios';
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";

export default function TimecardsTable() {

    const [Punch, setPunches] = useState([]);

        useEffect(() => {
        axios.get("http://localhost:5000/api/Punch").then(response => {
            console.log(response)
            setPunches(response.data)
            })
    }, [])

    return(
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
                    {Punch.map((Punch: any) => (
                        <TableRow
                            key={Punch.Id}
                            sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
                        >
                            <TableCell component="th" scope="row">
                                {Punch.id}
                            </TableCell>
                            <TableCell align="right">{Punch.Id}</TableCell>
                            <TableCell align="right">{Punch.clockIn}</TableCell>
                            <TableCell align="right">{Punch.clockOut}</TableCell>
                            <TableCell align="right">{Punch.clockInLongLat}</TableCell>
                            <TableCell align="right">{Punch.clockOutLongLat}</TableCell>
                        </TableRow>
                    ))}
                </TableBody>
            </Table>
        </TableContainer>

    
    );
}