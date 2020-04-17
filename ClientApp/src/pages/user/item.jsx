import React from 'react';

class UserItem extends React.Component {

    handleLabelChange = (event) => {
        let username = event.target.value;
        this.props.onItemUpdate({
            ...this.props.data,
            username
        });
    }
    handleLabelChange2 = (event) => {
        let pass = event.target.value;
        this.props.onItemUpdate({
            ...this.props.data,
            pass
        });
    }

    Login = (event) => {
        console.log("dang nhap");
        
        // event.preventDefault();
        // this.props.onItemRemove(this.props.data.id);
    }

    render() {
        const { data } = this.props;
        return (
            <div className="item">
                <input value={data.title} onChange={this.handleLabelChange} />
                <input value={data.title} onChange={this.handleLabelChange2} />
                <a href="#" onClick={this.Login}>Login</a>
            </div>
        );
    }
}

export default UserItem;
