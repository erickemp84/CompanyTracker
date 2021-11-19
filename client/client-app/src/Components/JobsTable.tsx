import * as React from "react";
import { useState, useEffect } from 'react';
import axios from 'axios';
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";
import Typography from '@mui/material/Typography';
import { Jobs } from '../Models/Jobs';
import Button from '@mui/material/Button';
import Modal from '@mui/material/Modal';
import Box from '@mui/material/Box';

//styling used for modals
const style = {
    position: 'absolute' as 'absolute',
    top: '50%',
    left: '50%',
    transform: 'translate(-50%, -50%)',
    width: 400,
    bgcolor: 'background.paper',
    border: '2px solid #000',
    boxShadow: 24,
    p: 4,
    };


export default function BasicTable() {

    //gets data from the database
    const [Jobs, setJobs] = useState<Jobs[]>([]);
    
    useEffect(() => {
        axios.get<Jobs[]>("http://localhost:5000/api/Job").then(response => {
            setJobs(response.data)
        })
    }, [])

    //modal functionality
    const [open, setOpen] = React.useState(false);
    const handleOpen = () => setOpen(true);
    const handleClose = () => setOpen(false);

    return (
        <>
            <TableContainer component={Paper} sx={{ width: 800 }}>
                <Typography
                    sx={{ flex: '1 1 100%', margin: 2 }}
                    variant="h6"
                    id="tableTitle"
                    component="div"
                >
                    Jobs
                </Typography>
                <Table sx={{ minWidth: 650 }} aria-label="simple table">
                    <TableHead>
                        <TableRow>
                            <TableCell>ID</TableCell>
                            <TableCell align="right">Description</TableCell>
                            <TableCell align="right">Location</TableCell>
                            <TableCell align="right">Customer</TableCell>
                            <TableCell align="right">Actions</TableCell>
                        </TableRow>
                    </TableHead>
                    <TableBody>
                        {Jobs.map(Job => (
                            <TableRow
                                key={Job.id}
                                sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
                            >
                                <TableCell component="th" scope="row">{Job.id}</TableCell>
                                <TableCell align="right">{Job.name}</TableCell>
                                <TableCell align="right">{Job.location}</TableCell>
                                <TableCell align="right">{Job.customer}</TableCell>
                                <TableCell align="right">
                                    <Button variant="contained" onClick={handleOpen}>Details</Button>
                                    <Modal
                                        open={open}
                                        onClose={handleClose}
                                        aria-labelledby="modal-modal-title"
                                        aria-describedby="modal-modal-description"
                                    >
                                        <Box sx={style}>
                                            <Typography id="modal-modal-title" variant="h6" component="h2">
                                                {Job.customer}
                                            </Typography>
                                            <Typography id="modal-modal-description" sx={{ mt: 2 }}>
                                                {Job.location}
                                            </Typography>
                                            <Typography id="modal-modal-description" sx={{ mt: 2 }}>
                                                {Job.name}
                                            </Typography>
                                        </Box>
                                    </Modal>
                                </TableCell>
                            </TableRow>
                        ))}
                    </TableBody>
                </Table>
            </TableContainer>
            <Button variant="contained" sx={{ mt: 4 }}>Add Job</Button>
        </>
    );
}
