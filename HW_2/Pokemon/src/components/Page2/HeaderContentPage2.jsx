import React from 'react';
import Pokeball from '../Pokeball';
import BackArrow from '../../Images/backArrow.png';
import { Link, BrowserRouter as Router } from 'react-router-dom';

const HeaderContentPage2 = () => {
    
    return (
            <div className='header_content_page2'>
            <div className='back_arrow'>
            <Link to="/">
                <img src={BackArrow} />
            </Link>
           
            </div>
            <div className='container_pokemon_ball'>
                <Pokeball/>
            </div>
        </div>
    );
};

export default HeaderContentPage2;