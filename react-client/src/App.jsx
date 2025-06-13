import './App.css'
import EnvInfo from './EnvInfo'
import Home from './Home';
import MyComponent from './MyComponent'
import { BrowserRouter, Route, Routes } from 'react-router-dom'

function App() {
  return (
    <BrowserRouter basename="/client">
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/env" element={<EnvInfo />} />
        <Route path="/component" element={<MyComponent />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App
