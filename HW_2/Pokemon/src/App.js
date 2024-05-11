import './App.css'
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import MainPage from './components/Page1/MainPage';
import PokemonInfoPage from './components/Page2/PokemonInfoPage';
function App() {
  return (
    <BrowserRouter>
      <div className="App">
        <Routes>
          <Route path='/' element={<MainPage/>}/>
          <Route path='/pokemon/:name' element={<PokemonInfoPage/>}/>
        </Routes>
      </div>
   </BrowserRouter>
  );
}

export default App;
