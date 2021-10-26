import React from 'react';
import './App.css';
import Sidebar from './Components/Sidebar';
import Content from './Components/Content';
import Box from '@mui/material/Box';

function App() {

  return (

    <>
      <Box className="container" sx={{display: 'flex'}}>
        <Sidebar />
        <Content />
      </Box>
    </>
  );
}

export default App;
