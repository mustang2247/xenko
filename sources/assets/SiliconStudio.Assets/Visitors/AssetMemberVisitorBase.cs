﻿using System;
using System.Collections;
using SiliconStudio.Core.Reflection;

namespace SiliconStudio.Assets.Visitors
{
    public abstract class AssetMemberVisitorBase : AssetVisitorBase
    {
        private readonly MemberPath memberPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetMemberVisitorBase"/> class.
        /// </summary>
        /// <param name="path">The path to check against the current member path being visited.</param>
        protected AssetMemberVisitorBase(MemberPath path)
        {
            if (path == null) throw new ArgumentNullException(nameof(path));
            memberPath = path;
        }

        /// <inheritdoc/>
        public override void VisitArrayItem(Array array, ArrayDescriptor descriptor, int index, object item, ITypeDescriptor itemDescriptor)
        {
            if (CurrentPath.Match(memberPath))
                VisitAssetMember(item, itemDescriptor);
            else
                base.VisitArrayItem(array, descriptor, index, item, itemDescriptor);
        }

        /// <inheritdoc/>
        public override void VisitCollectionItem(IEnumerable collection, CollectionDescriptor descriptor, int index, object item, ITypeDescriptor itemDescriptor)
        {
            if (CurrentPath.Match(memberPath))
                VisitAssetMember(item, itemDescriptor);
            else
                base.VisitCollectionItem(collection, descriptor, index, item, itemDescriptor);
        }

        /// <inheritdoc/>
        public override void VisitDictionaryKeyValue(object dictionary, DictionaryDescriptor descriptor, object key, ITypeDescriptor keyDescriptor, object value, ITypeDescriptor valueDescriptor)
        {
            if (CurrentPath.Match(memberPath))
            {
                Visit(key, keyDescriptor);
                VisitAssetMember(value, valueDescriptor);
            }
            else
            {
                base.VisitDictionaryKeyValue(dictionary, descriptor, key, keyDescriptor, value, valueDescriptor);
            }
        }

        /// <inheritdoc/>
        public override void VisitObjectMember(object container, ObjectDescriptor containerDescriptor, IMemberDescriptor member, object value)
        {
            if (CurrentPath.Match(memberPath))
                VisitAssetMember(value, member.TypeDescriptor);
            else
                base.VisitObjectMember(container, containerDescriptor, member, value);
        }

        /// <inheritdoc/>
        public override void VisitPrimitive(object primitive, PrimitiveDescriptor descriptor)
        {
            if (CurrentPath.Match(memberPath))
                VisitAssetMember(primitive, descriptor);
            else
                base.VisitPrimitive(primitive, descriptor);
        }

        /// <summary>
        /// Called when <see cref="AssetVisitorBase.CurrentPath"/> matches the <see cref="MemberPath"/> given when creating this instance.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="descriptor"></param>
        protected abstract void VisitAssetMember(object value, ITypeDescriptor descriptor);
    }
}
