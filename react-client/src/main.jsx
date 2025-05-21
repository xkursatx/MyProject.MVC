import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'


import React from 'react';
import ReactDOM from 'react-dom/client';
import MyComponent from './MyComponent';

// const rootEl = document.getElementById('root');
// if (rootEl) {
//   ReactDOM.createRoot(rootEl).render(<MyComponent />);
// }

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <App />
    <MyComponent />
  </StrictMode>,
)
