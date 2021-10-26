import React, {useState, useEffect} from 'react';
import axios from 'axios';
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";

export default function CustomerTable() {

    const[Customer, setCustomers] = useState([]);

    useEffect(() => {
        axios.get("http://localhost:5000/api/Customer").then(response => {
            console.log(response)
            setCustomers(response.data)
            })
    }, [])

    return(
        <TableContainer component={Paper} sx={{width: 800}}>
            <Table sx={{ minWidth: 650 }} aria-label="simple table">
                <TableHead>
                    <TableRow>
                        <TableCell>Name</TableCell>
                        <TableCell align="right">ID</TableCell>
                    </TableRow>
                </TableHead>
                <TableBody>
                    {Customer.map((Customer: any) => (
                        <TableRow
                            key={Customer.id}
                            sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
                        >
                            <TableCell component="th" scope="row">
                                {Customer.name}
                            </TableCell>
                            <TableCell align="right">{Customer.id}</TableCell>
                        </TableRow>
                    ))}
                </TableBody>
            </Table>
        </TableContainer>
        

    );
}

