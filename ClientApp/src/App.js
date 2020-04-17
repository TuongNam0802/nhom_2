import React from 'react';
import './App.scss';
import PageTodo from './pages/todo';
import PageUser from './pages/user';

function App() {
    console.log('app render')
    return (
        <div className="App">
            {/* <PageUser></PageUser> */}
            <PageTodo />
        
        </div>
    );
}

export default App;
