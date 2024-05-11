import React from 'react';
import style from './Search_button.module.css'
const SearchButton = ({children, ...prop}) => {
    return (
        <button {...prop} className={style.searchBtn}>
            {children}
        </button>
    );
};

export default SearchButton;