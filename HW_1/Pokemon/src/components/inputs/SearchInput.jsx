import React from 'react';
import style from './Search_input.module.css'
const SearchInput = (props) => {
    return (
        <input {...props} className={style.searchInput}/>
    );
};

export default SearchInput;