import React, { Component } from 'react';

class login extends Component {
    handleCheckboxChange = () => {
       alert("hello");
        };
    render() {
        return (
            <div>
                <form >
                    <div>
                    <input placeholder="User Name">
                    </input>
                    </div>
                    <div>
                    <input type="password" placeholder="Password">
                    </input>
                    </div>
                  <div>
                  <button onChange={this.handleCheckboxChange}>Login</button>
                    <button>Logout</button>
                  </div>
                </form>
            </div>
        );
    }
}

export default login;