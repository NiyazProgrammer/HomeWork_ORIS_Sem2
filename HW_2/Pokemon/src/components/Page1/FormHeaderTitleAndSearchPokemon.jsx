import React, { useMemo, useState } from 'react';
import SearchInput from '../inputs/SearchInput';
import SearchButton from '../buttons/SearchButton';
import searchImage from '../../Images/searchicon.png'
import Pokeball from '../Pokeball';
const FormHeaderTitleAndSearchPokemon = ({action}) => {

    const [text, setText] = useState('')
    useMemo(() => {
        action(text)
    },[text])
    return (
        <div>
            <div className='header_content'>
                <div className='container_for_title_and_ball'>
                    <div className='titel_header_container'>
                        <h className="title_header" >Who are you looking for ?</h>
                    </div>
                    <div className='container_poke_ball'>
                        <Pokeball/>
                    </div>
                </div>
                <div className='input_container'>
                    <form className='input_form'>
                        <img src={searchImage} className='searchImage' />
                        <SearchInput type='text' onChange={e => setText(e.target.value)} value={text} placeholder="Superman"/>
                        <SearchButton >GO</SearchButton>
                    </form>
                </div>
                
            </div>
        </div>
    );
};

export default FormHeaderTitleAndSearchPokemon;