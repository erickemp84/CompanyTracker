import React from 'react';
import TextField from '@mui/material/TextField';
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import FormControlLabel from '@mui/material/FormControlLabel';
import Checkbox from '@mui/material/Checkbox';

const SignIn = () => {

    return (

        <Box sx={{display: 'flex',
        flexDirection: 'column',
        alignItems: 'center', mt: 30}}>
        <Box sx={{height: 500, width: 350, display: 'flex',
            flexDirection: 'column',
            alignItems: 'center'}}>
        <h1>Sign In</h1>
        <Box component="form" noValidate sx={{ mt: 1 }} />
            <TextField
                margin="normal"
                required
                fullWidth
                id="email"
                label="Email Address"
                name="email"
                autoComplete="email"
                autoFocus
            />
            <TextField
                margin="normal"
                required
                fullWidth
                id="email"
                label="Password"
                name="password"
                autoComplete="password"
                autoFocus
            />
            <FormControlLabel
                control={<Checkbox value="remember" color="primary" />}
                label="Remember me"
            />
            <Button
                type="submit"
                fullWidth
                variant="contained"
                sx={{ height: 40, width: 100, mt: 3, mb: 2 }}
            >Sign In</Button>
        </Box>
        </Box>

    );

}

export default SignIn;