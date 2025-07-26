import logo from './logo.svg';
import './App.css';
import  Home  from './components/Home';
import  About  from './components/Aboutus';
import  Contact  from './components/Contact';

function App() {
  return (
    <div className="container">
      <Home />
      <About />
      <Contact />
    </div>
  );
}

export default App;


