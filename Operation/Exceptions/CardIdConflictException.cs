namespace Operation.Exceptions
{
    public sealed class CardIdConflictException : InitException
    {
        public short CardId { get; private set; }

        public CardIdConflictException(short id) => CardId = id;
    }
}
