import React from 'react';

const MovesCard = ({data}) => {
    return (
        <div className='moves_container'>
            <p>Moves</p>
            <div className='cards_container'>
                {data?.moves?.map(move => 
                    <div  className='moves_card'>
                    <p>{move.move.name}</p>
                </div>)}
            </div>
        </div> 
    );
};

export default MovesCard;